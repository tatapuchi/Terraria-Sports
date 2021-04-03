using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sports.Projectiles
{
    public class BowlingProjectile : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bowling Ball");
		}

		public override void SetDefaults()
		{

			projectile.scale = 0.7f;
			projectile.width = 40;
			projectile.height = 42;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.ranged = true;
			projectile.timeLeft = 3600;
			projectile.penetrate = 75;
			//projectile.velocity.Y = -5;
			//Change to blazing wheel
			aiType = ProjectileID.Boulder;
		}

		public override bool OnTileCollide(Vector2 oldVelocity)
		{
			if (projectile.velocity.X == 0)
            {
				projectile.Kill();
            }

			return false;
		}

        public override void AI()
        {

			projectile.rotation += 0.4f * (float)projectile.direction;
			base.AI();
		}
    }
}
