using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace ExampleMod.Content.Items.Placeable.Furniture
{
	public class ExampleWalkDustPlatform : ModItem
	{
		public override string Texture => $"Terraria/Images/Item_{ItemID.WoodPlatform}";

		public override void SetStaticDefaults() {
			Item.ResearchUnlockCount = 200;
		}

		public override void SetDefaults() {
			Item.DefaultToPlaceableTile(ModContent.TileType<Tiles.Furniture.ExampleWalkDustPlatform>());
			Item.width = 8;
			Item.height = 10;
		}

		public override void AddRecipes() {
			CreateRecipe(2)
				.AddIngredient<ExampleBlock>()
				.AddTile<Tiles.Furniture.ExampleWorkbench>()
				.Register();
		}
	}
}
