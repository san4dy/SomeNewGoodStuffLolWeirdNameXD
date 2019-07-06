using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace SomeNewGoodStuffLolWeirdNameXD.Items.Pickaxes
{
    public class AmethystPickaxe3 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Amethyst Pickaxe IV");
            Tooltip.SetDefault("Just another pickaxe");
        }
        public override void SetDefaults()
        {
            item.damage = 45;
            item.width = 28;
            item.height = 14;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 20;
            item.useTime = 20;
            item.pick = 240;
            item.useStyle = 1;
            item.rare = 2;
            item.value = 150;
        }
 
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "EnchantedAmethystBarInv", 15);
            recipe.AddIngredient(mod, "AmethystPickaxe2", 1);
            recipe.AddIngredient(ItemID.HallowedBar, 15);
            recipe.AddRecipeGroup("SummonersAssociation:SoulsOf", 5);
            recipe.AddTile(mod, "Amethyst_Anvil");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}