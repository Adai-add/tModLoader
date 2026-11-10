using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;

namespace ExampleMod.Content.Tiles.Furniture
{
	// Both items place this tile type with different styles from the vanilla platform texture.
	public class ExampleWalkDustPlatform : ExamplePlatform
	{
		internal const int SnowStyle = 49;

		public override string Texture => $"Terraria/Images/Tiles_{TileID.Platforms}";

		public override bool HasWalkDust(int frameX, int frameY) {
			int style = frameY / 18;
			return (style == 0 || style == SnowStyle) && Main.rand.NextBool(3);
		}

		public override void WalkDust(int frameX, int frameY, ref int dustType, ref bool makeDust, ref Color color) {
			// Use the selected floor tile's style, including when the player stands at its edge.
			dustType = frameY / 18 == SnowStyle ? DustID.Snow : DustID.WoodFurniture;
		}
	}
}
