using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ObjectData; 
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace SomeNewGoodStuffLolWeirdNameXD.Items.Armor_Inv
{
	[AutoloadEquip(EquipType.Body)]
	public class Amethyst_Breastplate : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Amethyst Breastplate");
			Tooltip.SetDefault("Increases your damage by: 30%");
		}
		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1000;
			item.rare = 5;
			item.defense = 37;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "EnchantedAmethystBarInv", 20);
			recipe.AddIngredient(ItemID.SoulofFright, 5);
			recipe.SetResult(this);
			recipe.AddTile(mod, "Amethyst_Anvil");
			recipe.AddRecipe();
		}
		public override void UpdateEquip(Player player)
		{
			player.meleeDamage += 0.3F;
            player.magicDamage += 0.3F;
            player.minionDamage += 0.3F;
            player.thrownDamage += 0.3F;
            player.rangedDamage += 0.3F;
		}
		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("Amethyst_Breastplate") && legs.type == mod.ItemType("Amethyst_Breastplate");
		}
		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Bonus set: Increased all damage by 30%\n Decreased get damage by 10%";
			player.meleeDamage += 0.3F;
            player.magicDamage += 0.3F;
            player.minionDamage += 0.3F;
            player.thrownDamage += 0.3F;
            player.rangedDamage += 0.3F;
			player.endurance += 0.1f;
		}
	}
}