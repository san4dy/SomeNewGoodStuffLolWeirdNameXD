using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ObjectData;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace SomeNewGoodStuffLolWeirdNameXD.NPCs
{
	class ModGlobalNPC : GlobalNPC
	{
		public override void NPCLoot(NPC npc)
		{
			if(npc.type == NPCID.Mothron)
			{
				if(Main.rand.NextFloat() < .2500f)
				{
					Item.NewItem(npc.getRect(), mod.ItemType("Broken Hero Bow"));
				}
			}
		}
	}
}