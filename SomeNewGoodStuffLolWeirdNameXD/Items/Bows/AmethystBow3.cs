using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace SomeNewGoodStuffLolWeirdNameXD.Items.Bows
{
	public class AmethystBow3 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Amethyst Bow IV");
			Tooltip.SetDefault("Bow made from Amethyst");
		}
		public override void SetDefaults()
		{
			item.damage = 140;
			item.noMelee = true;
			item.ranged = true;
			item.width = 69;
			item.height = 40;
			item.useTime = 6;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 1;
			item.value = 1000;
			item.rare = 1;
			item.UseSound = SoundID.Item5;
			item.autoReuse = true;
			item.shoot = 10;
			item.shootSpeed = 23f;
			item.useAmmo = ItemID.WoodenArrow;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "EnchantedAmethystBarInv", 10);
			recipe.AddIngredient(mod, "BrokenHeroBow");
			recipe.AddIngredient(mod, "AmethystBow2");
			recipe.AddTile(mod, "Amethyst_Anvil");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() > .66f;
		}
	}
}