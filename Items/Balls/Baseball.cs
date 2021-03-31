using Sports.Projectiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sports.Items.Balls
{
    public class Baseball : ModItem
    {
        public override void SetDefaults()
        {
			item.scale = 0.4f;
			item.noMelee = true;
			item.damage = 2;
			item.knockBack = 2.5f;
			item.thrown = true;
			item.width = 32;
			item.height = 32;
			item.maxStack = 999;
			item.useTime = 20;
			item.useAnimation = 20;
			item.consumable = true;
			//Speed of projectile(baseball) when thrown
			item.shootSpeed = 16;
			//Projectile(baseball) it launches
			item.shoot = ModContent.ProjectileType<BaseballProjectile>();
			//Throwing animation
			item.useStyle = ItemUseStyleID.SwingThrow;
			//Cost of baseball(copper coins) when sold
			item.value = 6;
			item.UseSound = SoundID.Item1;
			item.rare = ItemRarityID.White;
		}

        public override void SetStaticDefaults()
        {
			DisplayName.SetDefault("Baseball"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Whack it with a bat... or just throw it.");

		}

		//Recipie
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);

			//Ingredients
			recipe.AddIngredient(ItemID.Hay, 10);
			recipe.AddIngredient(ItemID.Gel, 3);

			//Crafting stations
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);

			recipe.AddRecipe();
		}

	}
}
