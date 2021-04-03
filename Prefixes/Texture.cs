using Sports.Items.Balls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace Sports.Prefixes
{
    public class Texture: ModPrefix
    {    
        private string name;
        private float power;
        private float value;
        public Texture(string name, float power, float value)
        {
            this.name = name;
            this.power = power;
            this.value = value;
        }

        public Texture()
        {
            this.name = "Textured";
            this.power = 1f;
            this.value = 1f;
        }

        public override bool Autoload(ref string name)
        {

            mod.AddPrefix("Smooth", new Consistency("Smooth", 4f, 4f));
            mod.AddPrefix("Rough", new Consistency("Rough", 3f, 3f));
            return false;
        }

        public override bool CanRoll(Item item)
        {
            if (item.type == ModContent.ItemType<BowlingBall>())
            {
                return true;
            }

            return false;
        }

        public override float RollChance(Item item) => 12f;

        public override PrefixCategory Category => PrefixCategory.AnyWeapon;

        public override void ModifyValue(ref float valueMult)
        {
            valueMult = value;
        }



        public override void SetDefaults()
        {
            DisplayName.SetDefault(name);
        }

        public override void SetStats(ref float damageMult, ref float knockbackMult, ref float useTimeMult, ref float scaleMult, ref float shootSpeedMult, ref float manaMult, ref int critBonus)
        {
            damageMult = power;
            knockbackMult = power;
            shootSpeedMult = power;
        }
    }
}
