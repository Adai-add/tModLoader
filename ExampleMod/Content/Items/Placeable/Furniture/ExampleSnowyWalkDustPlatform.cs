using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExampleMod.Content.Items.Placeable.Furniture
{
	public class ExampleSnowyWalkDustPlatform : ModItem
	{
		public override string Texture => $"Terraria/Images/Item_{ItemID.SnowPlatform}";

		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 200;
		}

		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.ExampleWalkDustPlatform>(), Tiles.Furniture.ExampleWalkDustPlatform.SnowStyle);
			Item.width = 8;
			Item.height = 10;
		}

		public override void AddRecipes() {
			CreateRecipe(2)
				.AddIngredient<ExampleWalkDustPlatform>(2)
				.AddIngredient(ItemID.SnowBlock)
				.AddTile<Tiles.Furniture.ExampleWorkbench>()
				.Register();
		}
	}
}
