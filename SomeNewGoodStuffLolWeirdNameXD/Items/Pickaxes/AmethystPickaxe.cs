using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace SomeNewGoodStuffLolWeirdNameXD.Items.Pickaxes
{
    public class AmethystPickaxe : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Amethyst Pickaxe I");
            Tooltip.SetDefault("Just another pickaxe");
        }
        public override void SetDefaults()
        {
            item.damage = 10;
            item.width = 28;
            item.height = 14;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 20;
            item.useTime = 20;
            item.pick = 75;
            item.useStyle = 1;
            item.rare = 2;
            item.value = 150;
        }
 
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "AmethystBarInv", 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}