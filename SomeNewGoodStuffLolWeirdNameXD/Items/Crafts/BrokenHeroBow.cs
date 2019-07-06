using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace SomeNewGoodStuffLolWeirdNameXD.Items.Crafts
{
	public class BrokenHeroBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Broken Hero Bow");
		}
		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 42;
			item.maxStack = 99;
			item.value = 100;
			item.rare = 3;
		}
	}
}