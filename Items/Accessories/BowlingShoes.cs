using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Sports.Items.Accessories
{
    public class BowlingShoes: ModItem
    {
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bowling Shoes");
			Tooltip.SetDefault("Just slippery I guess.");
		}

		public override void SetDefaults()
		{
			item.width = 36;
			item.height = 38;
			item.accessory = true; // Makes this item an accessory.
			item.rare = ItemRarityID.Blue;
			item.value = Item.sellPrice(gold: 1); // Sets the item sell price to one gold coin.
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.accRunSpeed = 6f; // The player's maximum run speed with accessories
			player.moveSpeed += 0.05f; // The acceleration multiplier of the player's movement speed
		}


		//Recipie
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);

			//Ingredients
			recipe.AddIngredient(ItemID.Hay, 50);
			recipe.AddIngredient(ItemID.Gel, 10);

			//Crafting stations
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);

			recipe.AddRecipe();
		}
	}
}
