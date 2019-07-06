using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace SomeNewGoodStuffLolWeirdNameXD.Items.Pickaxes
{
    public class AmethystPickaxe2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Amethyst Pickaxe III");
            Tooltip.SetDefault("Just another pickaxe");
        }
        public override void SetDefaults()
        {
            item.damage = 25;
            item.width = 28;
            item.height = 14;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 20;
            item.useTime = 20;
            item.pick = 165;
            item.useStyle = 1;
            item.rare = 2;
            item.value = 150;
        }
 
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "EnchantedAmethystBarInv", 10);
            recipe.AddIngredient(mod, "AmethystPickaxe1", 1);
            recipe.AddTile(mod, "Amethyst_Anvil");
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}