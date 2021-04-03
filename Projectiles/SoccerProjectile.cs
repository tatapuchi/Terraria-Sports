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
    public class SoccerProjectile : ModProjectile
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Soccer Ball");
		}

		public override void SetDefaults()
		{

			projectile.scale = 0.6f;
			projectile.width = 40;
			projectile.height = 42;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.hostile = true;
			projectile.ranged = true;
			projectile.timeLeft = 3600;
			projectile.penetrate = 5;
			aiType = ProjectileID.BeachBall;
		}


		//Bouncing Projectile
		public override bool OnTileCollide(Vector2 oldVelocity)
		{

				Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
				Main.PlaySound(SoundID.Item10, projectile.position);
				if (projectile.velocity.X != oldVelocity.X)
				{
					projectile.velocity.X = -oldVelocity.X;
				}
				if (projectile.velocity.Y != oldVelocity.Y)
				{
					projectile.velocity.Y = -oldVelocity.Y;
				}
			return false;
		}

		public override void OnHitPlayer(Player target, int damage, bool crit)
		{

			Collision.HitTiles(projectile.position + projectile.velocity, projectile.velocity, projectile.width, projectile.height);
			Main.PlaySound(SoundID.Item10, projectile.position);
			//if (projectile.velocity.X != projectile.oldVelocity.X)
			//{
				projectile.velocity.X = -projectile.velocity.X;

				//if (projectile.velocity.Y != projectile.oldVelocity.Y)
				//{
					projectile.velocity.Y = -projectile.velocity.Y;
				//}

		
			//}
		}
    }
}
