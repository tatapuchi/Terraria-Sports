using Sports.Prefixes;
using Sports.Projectiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace Sports.Items.Balls
{
    public class SoccerBall: ModItem
    {
		public override void SetDefaults()
		{
			item.scale = 0.6f;
			item.noMelee = true;
			item.damage = 2;
			item.knockBack = 1f;
			item.thrown = true;
			item.width = 40;
			item.height = 42;
			item.maxStack = 1;
			item.useTime = 20;
			item.useAnimation = 20;
			item.consumable = true;
			//Speed of projectile(baseball) when thrown
			item.shootSpeed = 8;
			//Projectile(baseball) it launches
			item.shoot = ModContent.ProjectileType<SoccerProjectile>();
			//Throwing animation
			item.useStyle = ItemUseStyleID.SwingThrow;
			//Cost of baseball(copper coins) when sold
			item.value = Item.sellPrice(silver:14);
			item.UseSound = SoundID.Item1;
			item.rare = ItemRarityID.Blue;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Soccer Ball"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Also known as a football.");

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
