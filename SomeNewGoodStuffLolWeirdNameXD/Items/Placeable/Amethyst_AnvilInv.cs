using Terraria.ID;
using Terraria.ModLoader;
 
namespace SomeNewGoodStuffLolWeirdNameXD.Items.Placeable
{
    public class Amethyst_AnvilInv : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Amethyst Anvil");
            Tooltip.SetDefault("Required to make last versions of items, armor an accessories from Amethyst");
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
            item.createTile = mod.TileType("Amethyst_Anvil");
        }
 
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "EnchantedAmethystBarInv", 5);
            recipe.AddIngredient(ItemID.OrichalcumAnvil, 1);
            recipe.AddTile(mod, "EnchancedAmethystFurnace");
            recipe.SetResult(this);
            recipe.AddRecipe();
            recipe.AddIngredient(mod, "EnchantedAmethystBarInv", 15);
            recipe.AddIngredient(ItemID.MythrilAnvil);
            recipe.AddTile(mod, "EnchancedAmethystFurnace");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}