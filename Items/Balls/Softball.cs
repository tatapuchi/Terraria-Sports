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
    public class Softball: ModItem
    {

		public override void SetDefaults()
		{
			item.scale = 0.3f;
			item.noMelee = true;
			item.damage = 1;
			item.knockBack = 1.5f;
			item.thrown = true;
			item.width = 32;
			item.height = 32;
			item.maxStack = 12;
			item.useTime = 20;
			item.useAnimation = 20;
			item.consumable = true;
			//Speed of projectile(softball) when thrown
			item.shootSpeed = 20;
			//Projectile(softball) it launches
			item.shoot = ModContent.ProjectileType<SoftballProjectile>();
			//Throwing animation
			item.useStyle = ItemUseStyleID.SwingThrow;
			//Cost of softball(copper coins) when sold
			item.value = 6;
			item.UseSound = SoundID.Item1;
			item.rare = ItemRarityID.White;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Softball"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Isn't this just a baseball?");

		}

		//Recipie
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);

			//Ingredients
			recipe.AddIngredient(ItemID.Hay, 5);
			recipe.AddIngredient(ItemID.Gel, 3);

			//Crafting stations
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);

			recipe.AddRecipe();
		}

	}
}
