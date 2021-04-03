using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace Sports.Prefixes
{
    public class Inflation: ModPrefix
    {
        private string name;
        private float power;
        private float value;
        public Inflation()
        {
            name = "Inflated";
            power = 1f;
            value = 1f;
        }

        public Inflation(string name, float power, float value)
        {
            this.name = name;
            this.power = power;
            this.value = value;
        }

        public override bool CanRoll(Item item)
        {
            return true;
        }


        public override float RollChance(Item item) => 8f;
        public override PrefixCategory Category => PrefixCategory.AnyWeapon;

        public override bool Autoload(ref string name)
        {
            mod.AddPrefix("HyperInflated", new Inflation("Hyper-Inflated", 5f, 5f));
            mod.AddPrefix("SuperInflated", new Inflation("Super-Inflated", 5f, 5f));
            mod.AddPrefix("Deflated", new Inflation("Deflated", 0.5f, 0.5f));
            mod.AddPrefix("Punctured", new Inflation("Punctured", 0.2f, 0.2f));
            mod.AddPrefix("Torn", new Inflation("Torn", 0.1f, 0.1f));
            return false;
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

        public override void ModifyValue(ref float valueMult)
        {
            valueMult = value;
        }

        public override void Apply(Item item)
        {
            base.Apply(item);
        }
    }
}
