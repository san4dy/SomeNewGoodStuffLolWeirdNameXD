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

	public class AmethystSword3 : ModItem{

		public override void SetStaticDefaults(){

			DisplayName.SetDefault("Amethyst Sword IV");
			Tooltip.SetDefault("Additional effect: Lifesteal + Projectile shot");
		}
		public override void SetDefaults(){

			item.damage = 140;
			item.melee = true;
			item.width = 45;
			item.height = 45;
			item.useTime = 18;
			item.crit = 18;
			item.useAnimation = 18;
			item.useStyle = 1;
			item.knockBack = 4;
			item.value = 3000;
			item.rare = 4;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("AmethystProjectile");
			item.useTurn = true;
			item.shootSpeed = 8f;
		}
		public override void AddRecipes() {

			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod, "EnchantedAmethystBarInv", 10);
			recipe.AddIngredient(mod, "AmethystSword2");
			recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
			recipe.AddTile(mod, "Amethyst_Anvil");
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		public override void OnHitNPC(Player player, NPC target, int damage, float knockback, bool crit) {

			int healingAm = damage/10;
			player.statLife += healingAm;
			player.HealEffect(healingAm, true);
		}
		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
            int numberProjectiles = 6 + Main.rand.Next(4);  //This defines how many projectiles to shot
            for (int index = 0; index < numberProjectiles; ++index)
            {
                Vector2 vector2_1 = new Vector2((float)((double)player.position.X + (double)player.width * 0.5 + (double)(Main.rand.Next(201) * -player.direction) + ((double)Main.mouseX + (double)Main.screenPosition.X - (double)player.position.X)), (float)((double)player.position.Y + (double)player.height * 0.5 - 600.0));   //this defines the projectile width, direction and position
                vector2_1.X = (float)(((double)vector2_1.X + (double)player.Center.X) / 2.0) + (float)Main.rand.Next(-200, 201);
                vector2_1.Y -= (float)(100 * index);
                float num12 = (float)Main.mouseX + Main.screenPosition.X - vector2_1.X;
                float num13 = (float)Main.mouseY + Main.screenPosition.Y - vector2_1.Y;
                if ((double)num13 < 0.0) num13 *= -1f;
                if ((double)num13 < 20.0) num13 = 20f;
                float num14 = (float)Math.Sqrt((double)num12 * (double)num12 + (double)num13 * (double)num13);
                float num15 = item.shootSpeed / num14;
                float num16 = num12 * num15;
                float num17 = num13 * num15;
                float SpeedX = num16 + (float)Main.rand.Next(-40, 41) * 0.04f;  //this defines the projectile X position speed and randomnes
                float SpeedY = num17 + (float)Main.rand.Next(-40, 41) * 0.04f;  //this defines the projectile Y position speed and randomnes
                Projectile.NewProjectile(vector2_1.X, vector2_1.Y, SpeedX, SpeedY, type, damage, knockBack, Main.myPlayer, 0.0f, (float)Main.rand.Next(5));
            }
            return false;
        }
	}
}