using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SomeNewGoodStuffLolWeirdNameXD.Projectiles
{
	public class AmethystProjectile : ModProjectile 
	{
		public override void SetStaticDefaults(){
			DisplayName.SetDefault("AmethystProjectile");
		}
		public override void SetDefaults() 
		{
			projectile.width = 27;
			projectile.height = 24;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.tileCollide = true;
			projectile.penetrate = 2;
			projectile.timeLeft = 300;
			projectile.light = 0.85f;
			projectile.extraUpdates = 1;
			projectile.ignoreWater = true;
		}

		public override void AI()
		{
			projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X);
			if (Main.rand.Next(6) == 0)
				{
					int dustnumber = Dust.NewDust(projectile.position, projectile.width, projectile.height, 73, 0f, 0f, 200, default(Color), 1.4f);
					Main.dust[dustnumber].velocity *= 1.3f;
				}
		}
	}
}