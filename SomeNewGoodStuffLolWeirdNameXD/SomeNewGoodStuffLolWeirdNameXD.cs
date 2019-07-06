using Terraria.ID;
using Terraria.Localization;
using Terraria;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace SomeNewGoodStuffLolWeirdNameXD
{
	class SomeNewGoodStuffLolWeirdNameXD : Mod
	{
		public SomeNewGoodStuffLolWeirdNameXD()
		{

		}
		public override void AddRecipes()
		{
			RecipeFinder finder = new RecipeFinder();
			finder.AddIngredient(ItemID.Amethyst, 8);
			finder.AddIngredient(ItemID.CopperBar, 10);
			foreach (Recipe recipe in finder.SearchRecipes())
			{
				RecipeEditor editor = new RecipeEditor(recipe);
				editor.DeleteRecipe();
			}

		}
		public override void AddRecipeGroups()
		{
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Soul", new int[]
    			{
    				ItemID.SoulofMight,
    				ItemID.SoulofFright,
    				ItemID.SoulofSight
    			});
    		RecipeGroup.RegisterGroup("SummonersAssociation:SoulsOf", group);
    		RecipeGroup group1 = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Hardmode Furnace", new int[]
    			{
    				ItemID.AdamantiteForge,
    				ItemID.TitaniumForge
    			});
    		RecipeGroup.RegisterGroup("SummonersAssociation:Forges", group1);
		}
	}
}
