using Sports.Projectiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sports.Items.Balls
{
    public class BowlingBall: ModItem
    {
		public override void SetDefaults()
		{
			item.scale = 0.7f;
			item.noMelee = true;
			item.damage = 45;
			item.knockBack = 5.5f;
			item.thrown = true;
			item.width = 40;
			item.height = 42;
			item.maxStack = 1;
			item.useTime = 20;
			item.useAnimation = 20;
			item.consumable = true;
			//Speed of projectile(baseball) when thrown
			item.shootSpeed = 4;
			//Projectile(baseball) it launches
			item.shoot = ModContent.ProjectileType<BowlingProjectile>();
			//Throwing animation
			item.useStyle = ItemUseStyleID.SwingThrow;
			//Cost of baseball(copper coins) when sold
			item.value = Item.sellPrice(silver: 18);
			item.UseSound = SoundID.Item1;
			item.rare = ItemRarityID.Blue;
		}

		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bowling Ball"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Man this thing is heavy.");

		}

		//Recipie
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);

			//Ingredients
			recipe.AddIngredient(ItemID.MarbleBlock, 25);

			//Crafting stations
			recipe.AddTile(TileID.HeavyWorkBench);
			recipe.SetResult(this);

			recipe.AddRecipe();
		}
	}
}
