using Terraria.ID;
using Terraria.ModLoader;
 
namespace SomeNewGoodStuffLolWeirdNameXD.Items.Placeable
{
    public class EnchancedAmethystFurnaceInv : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Enchanced Amethyst Furnace");
            Tooltip.SetDefault("Amethyst Furnace");
        }
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 14;
            item.maxStack = 99;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 10;
            item.useStyle = 1;
            item.consumable = true;
            item.value = 150;
            item.createTile = mod.TileType("EnchancedAmethystFurnace");
        }
 
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "AmethystBarInv", 10);
            recipe.AddIngredient(mod, "AmethystFurnaceInv", 1);
            recipe.AddRecipeGroup("SummonersAssociation:Forges", 1);
            recipe.AddIngredient(ItemID.HallowedBar, 20);
            recipe.AddIngredient(ItemID.SoulofFright, 5);
            recipe.AddIngredient(ItemID.SoulofMight, 5);
            recipe.AddIngredient(ItemID.SoulofSight, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}