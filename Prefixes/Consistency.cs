using Sports.Items.Balls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sports.Prefixes
{
    public class Consistency : ModPrefix
    {
        private string name;
        private float power;
        private float value;
        public Consistency(string name, float power, float value)
        {
            this.name = name;
            this.power = power;
            this.value = value;
        }

        public Consistency()
        {
            this.name = "Consistent";
            this.power = 1f;
            this.value = 1f;
        }

        public override bool Autoload(ref string name)
        { 

            mod.AddPrefix("Hard", new Consistency("Hard", 4f, 4f));
            mod.AddPrefix("Soft", new Consistency("Soft", 0.75f, 0.75f));
            mod.AddPrefix("Pulpy", new Consistency("Pulpy", 0.6f, 0.6f));
            mod.AddPrefix("Squishy", new Consistency("Squishy", 0.4f, 0.4f));
            return false;
        }

        public override bool CanRoll(Item item)
        {
            if(item.type == ModContent.ItemType<SoccerBall>())
            {
                return true;
            }

            return false;
        }

        public override float RollChance(Item item)
        {
            return 12f;
        }

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
