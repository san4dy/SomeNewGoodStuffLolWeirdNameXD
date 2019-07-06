using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace SomeNewGoodStuffLolWeirdNameXD.Items.Accesories_Inv
{
	[AutoloadEquip(EquipType.Shoes)]
	class Amethystspark_Boots : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Amethyst-Spark Boots");
			Tooltip.SetDefault("Really... I'm tired of writing theese. KMS :<");
		}
		public override void SetDefaults()
		{
			item.width = 6;
			item.height = 13;
			item.value = 1000;
			item.rare = 5;
			item.accessory = true;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.accRunSpeed = 8f;
			player.rocketBoots = 3;
			player.rocketTime = 1400;
			player.iceSkate = true;
			player.dash = 1;
			player.longInvince = true;
			player.lavaRose = true;
			player.fireWalk = true;
			player.waterWalk = true;
			player.noFallDmg = true;
			player.accFlipper = true;
			player.ignoreWater = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.FrostsparkBoots, 1);
			recipe.AddIngredient(mod, "EnchantedAmethystBarInv", 15);
			recipe.AddTile(mod, "Amethyst_Anvil");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
