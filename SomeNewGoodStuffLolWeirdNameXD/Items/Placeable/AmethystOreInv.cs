using Terraria.ModLoader;
using Terraria.ID;

namespace SomeNewGoodStuffLolWeirdNameXD.Items.Placeable
{
    public class AmethystOreInv : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Amethyst Ore");
            Tooltip.SetDefault("Required to make amethyst stuff.");
        }

        public override void SetDefaults()
        {
            item.width = 12; // Hitbox Width
            item.height = 12; // Hitbox Height
            item.useTime = 20; // Speed before reuse
            item.useAnimation = 20; // Animation Speed
            item.useStyle = 1; // 1 = Broadsword 
            item.value = 50; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.rare = 2; // Item Tier
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false
            item.consumable = true; // Will consume the item when placed.
            item.createTile = mod.TileType("AmethystOre");
            item.maxStack = 999; // The maximum number you can have of this item.
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Amethyst, 1);
            recipe.AddIngredient(ItemID.GoldOre, 1);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(mod, "AmethystOreInv", 2);
            recipe.AddRecipe();
             recipe.AddIngredient(ItemID.Amethyst, 1);
            recipe.AddIngredient(ItemID.PlatinumOre, 1);
            recipe.AddTile(TileID.Furnaces);
            recipe.SetResult(mod, "AmethystOreInv", 2);
            recipe.AddRecipe();

        }
    }
}