using Terraria.ID;
using Terraria.ModLoader;
 
namespace SomeNewGoodStuffLolWeirdNameXD.Items.Placeable
{
    public class AmethystFurnaceInv : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Amethyst Furnace");
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
            item.createTile = mod.TileType("AmethystFurnace");
        }
 
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "AmethystOreInv", 10);
            recipe.AddIngredient(ItemID.Furnace, 1);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}