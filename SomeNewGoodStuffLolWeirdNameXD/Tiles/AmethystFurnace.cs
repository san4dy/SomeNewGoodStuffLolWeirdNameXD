using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ObjectData;

namespace SomeNewGoodStuffLolWeirdNameXD.Tiles
{
	public class AmethystFurnace : ModTile
	{
		public override void SetDefaults()
		{
      		Main.tileSolidTop[Type] = false;
                  Main.tileFrameImportant[Type] = true;
                  Main.tileNoAttach[Type] = true;
                  Main.tileTable[Type] = false;
                  Main.tileLavaDeath[Type] = true;
                  Main.tileBlockLight[Type] = true;

                  TileObjectData.newTile.CopyFrom(TileObjectData.Style3x2);
                  ModTranslation name = CreateMapEntryName();
                  AddMapEntry(new Color(0, 0, 0), name);
                  AddToArray(ref TileID.Sets.RoomNeeds.CountsAsTorch);
                  disableSmartCursor = true;
                  adjTiles = new int[] { TileID.AdamantiteForge };
                  TileObjectData.addTile(Type);
		}
            public override void NumDust(int i, int j, bool fail, ref int num)
            {
                  num = fail ? 1 : 3;
            }
            public override void KillMultiTile(int i, int j, int frameX, int frameY)
            {
                  Item.NewItem(i * 16, j * 16, 48, 32, mod.ItemType("AmethystFurnaceInv"));
            }
	}
}