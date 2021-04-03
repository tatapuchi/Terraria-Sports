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
    public class ShuttleCock: ModItem
    {
		public override void SetDefaults()
		{
			item.scale = 0.15f;
			item.noMelee = true;
			item.damage = 1;
			item.knockBack = 0.5f;
			item.thrown = true;
			item.width = 40;
			item.height = 42;
			item.maxStack = 12;
			item.useTime = 20;
			item.useAnimation = 20;
			item.consumable = true;
			//Speed of projectile(baseball) when thrown
			item.shootSpeed = 6;
			//Projectile(baseball) it launches
			item.shoot = ModContent.ProjectileType<BadmintonProjectile>();
			//Throwing animation
			item.useStyle = ItemUseStyleID.SwingThrow;
			//Cost of baseball(copper coins) when sold
			item.value = 6;
			item.UseSound = SoundID.Item1;
			item.rare = ItemRarityID.White;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Shuttlecock"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Badminton fun.");

		}

		//Recipie
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);

			//Ingredients
			recipe.AddIngredient(ItemID.Hay, 5);
			recipe.AddIngredient(ItemID.Gel, 2);

			//Crafting stations
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);

			recipe.AddRecipe();
		}
	}
}
