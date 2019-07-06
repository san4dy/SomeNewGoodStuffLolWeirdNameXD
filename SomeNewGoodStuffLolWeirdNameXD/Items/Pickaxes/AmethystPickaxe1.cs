using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace SomeNewGoodStuffLolWeirdNameXD.Items.Pickaxes
{
    public class AmethystPickaxe1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Amethyst Pickaxe II");
            Tooltip.SetDefault("Just another pickaxe");
        }
        public override void SetDefaults()
        {
            item.damage = 18;
            item.width = 28;
            item.height = 14;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 20;
            item.useTime = 20;
            item.pick = 105;
            item.useStyle = 1;
            item.rare = 3;
            item.value = 150;
        }
 
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Amethyst, 5);
            recipe.AddIngredient(mod, "AmethystPickaxe", 1);
            recipe.AddIngredient(ItemID.HellstoneBar, 15);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}