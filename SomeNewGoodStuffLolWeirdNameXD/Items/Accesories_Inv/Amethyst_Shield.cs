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
	[AutoloadEquip(EquipType.Shield)]
	class Amethyst_Shield : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Amethyst Shield");
			Tooltip.SetDefault("Shield which is granting immunity to most debuffs, gives 5% damage resistance and 5% more dealing damage");
		}
		public override void SetDefaults()
		{
			item.width = 6;
			item.height = 13;
			item.value = 1000;
			item.rare = 5;
			item.accessory = true;
			item.defense = 15;
			item.damage = 20;
		}
		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.noKnockback = true;
			player.dash = 1;
			player.endurance += 0.05f;
			player.longInvince = true;
			player.lavaRose = true;
			player.fireWalk = true;
			player.starCloak = true;
			player.buffImmune[46] = true;
			player.buffImmune[33] = true;
		    player.buffImmune[36] = true;
		    player.buffImmune[30] = true;
		    player.buffImmune[20] = true;
		    player.buffImmune[32] = true;
		    player.buffImmune[31] = true;
		    player.buffImmune[35] = true;
		    player.buffImmune[23] = true;
		    player.buffImmune[22] = true;
		    player.AddBuff(BuffID.PaladinsShield, 2);
		    player.meleeDamage += (player.meleeDamage / 100) * 5;
            player.magicDamage += (player.magicDamage / 100) * 5;
            player.rangedDamage += (player.rangedDamage / 100) * 5;
            player.minionDamage += (player.minionDamage / 100) * 5;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(3097, 1);
			recipe.AddIngredient(ItemID.AnkhShield);
			recipe.AddIngredient(ItemID.StarCloak);
			recipe.AddIngredient(mod, "EnchantedAmethystBarInv", 15);
			recipe.AddIngredient(ItemID.Lens, 15);
			recipe.AddTile(mod, "Amethyst_Anvil");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
