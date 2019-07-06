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
	class AmethystStaff3 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Amethyst Staff IV");
			Tooltip.SetDefault("Staff made from Amethyst");
			Item.staff[item.type] = true;
		}
		public override void SetDefaults()
		{
			item.damage = 140;
			item.magic = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 40;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 2f;
			item.value = 1000;
			item.mana = 9;
			item.UseSound = SoundID.Item21;
			item.autoReuse = true;
			item.shoot = ProjectileID.Typhoon;
			item.shootSpeed = 8f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "EnchantedAmethystBarInv", 10);
			recipe.AddIngredient(mod, "AmethystStaff2");
			recipe.AddIngredient(mod, "BrokenHeroStaff");
			recipe.AddTile(mod, "Amethyst_Anvil");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}	