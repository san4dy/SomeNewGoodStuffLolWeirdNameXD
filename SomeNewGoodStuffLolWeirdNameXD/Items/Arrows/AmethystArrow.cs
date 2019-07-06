using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace SomeNewGoodStuffLolWeirdNameXD.Items.Arrows
{
	public class AmethystArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Amethyst Arrow");
		}
		public override void SetDefaults()
		{
			item.damage = 8;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.useAnimation = 20;
			item.useStyle = 3;
			item.consumable = true;
			item.knockBack = 2f;
			item.value = 100;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
			item.shoot = mod.ProjectileType("AmethystArrowProj");
			item.shootSpeed = 4f;
			item.ammo = 40;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Amethyst, 2);
			recipe.SetResult(mod, "AmethystArrow", 20);
			recipe.AddRecipe();
		}
	}
}