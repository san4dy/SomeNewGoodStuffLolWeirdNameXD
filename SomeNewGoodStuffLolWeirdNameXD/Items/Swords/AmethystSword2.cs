using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;


namespace SomeNewGoodStuffLolWeirdNameXD.Items.Swords
{
	public class AmethystSword2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Amethyst Sword III");
			Tooltip.SetDefault("Additional effect: Lifesteal");
		}
		public override void SetDefaults()
		{
			item.damage = 70;
			item.melee = true;
			item.width = 45;
			item.height = 45;
			item.useTime = 18;
			item.crit = 18;
			item.useAnimation = 18;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 3000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
		}
		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "AmethystSword1");
			recipe.AddIngredient(ItemID.HallowedBar, 15);
			recipe.AddIngredient(ItemID.SoulofFright, 10);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit)
		{
			int healingAm = damage/15;
			player.statLife += healingAm;
			player.HealEffect(healingAm, true);
		}
	}
}