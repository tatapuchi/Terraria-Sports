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
    public class TennisBall: ModItem
    {
		public override void SetDefaults()
		{
			item.scale = 0.35f;
			item.noMelee = true;
			item.damage = 3;
			item.knockBack = 2.0f;
			item.thrown = true;
			item.width = 40;
			item.height = 42;
			item.maxStack = 12;
			item.useTime = 20;
			item.useAnimation = 20;
			item.consumable = true;
			//Speed of projectile(baseball) when thrown
			item.shootSpeed = 12;
			//Projectile(baseball) it launches
			item.shoot = ModContent.ProjectileType<TennisProjectile>();
			//Throwing animation
			item.useStyle = ItemUseStyleID.SwingThrow;
			//Cost of baseball(copper coins) when sold
			item.value = 6;
			item.UseSound = SoundID.Item1;
			item.rare = ItemRarityID.White;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Tennis Ball"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Green and bouncy.");

		}

		//Recipie
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);

			//Ingredients
			recipe.AddIngredient(ItemID.Hay, 15);
			recipe.AddIngredient(ItemID.Gel, 5);

			//Crafting stations
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);

			recipe.AddRecipe();
		}
	}
}
