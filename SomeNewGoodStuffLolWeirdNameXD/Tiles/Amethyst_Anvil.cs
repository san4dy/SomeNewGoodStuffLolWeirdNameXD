using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace SomeNewGoodStuffLolWeirdNameXD.Tiles
{
	public class Amethyst_Anvil : ModTile
	{
		public override void SetDefaults()
		{
      		Main.tileSolidTop[Type] = false;
                  Main.tileFrameImportant[Type] = true;
                  Main.tileNoAttach[Type] = true;
                  Main.tileTable[Type] = false;
                  Main.tileLavaDeath[Type] = true;
                  Main.tileBlockLight[Type] = false;

                  TileObjectData.newTile.CopyFrom(TileObjectData.Style2x1);
                  ModTranslation name = CreateMapEntryName();
                  AddMapEntry(new Color(255, 0, 191), name);
                  disableSmartCursor = true;
                  adjTiles = new int[] { TileID.MythrilAnvil };
                  TileObjectData.addTile(Type);
		}
            public override void NumDust(int i, int j, bool fail, ref int num)
            {
                  num = fail ? 1 : 2;
            }
            public override void KillMultiTile(int i, int j, int frameX, int frameY)
            {
                  Item.NewItem(i * 16, j * 16, 32, 16, mod.ItemType("Amethyst_Anvil"));
            }
	}
}