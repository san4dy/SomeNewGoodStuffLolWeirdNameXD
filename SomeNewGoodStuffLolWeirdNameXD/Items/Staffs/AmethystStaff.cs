using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace SomeNewGoodStuffLolWeirdNameXD.Items.Staffs
{
	public class AmethystStaff : ModItem
	{
		public override string Texture { get { return "Terraria/Item_" + ItemID.AmethystStaff; } }
		public override void SetStaticDefaults()
		{
			Item.staff[item.type] = true;
			DisplayName.SetDefault("Amethyst Staff I");
			Tooltip.SetDefault("Staff made from Amethyst");
		}
		public override void SetDefaults()
		{
			item.CloneDefaults(ItemID.AmethystStaff);
			item.damage = 18;
			item.shoot = ProjectileID.AmethystBolt;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "AmethystBarInv", 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}