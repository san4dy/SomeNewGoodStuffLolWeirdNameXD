using Terraria.ModLoader;
using Terraria.ID;

namespace SomeNewGoodStuffLolWeirdNameXD.Items.Placeable
{
    public class AmethystBarInv : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Amethyst Bar");
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
            item.createTile = mod.TileType("AmethystBar");
            item.maxStack = 999; // The maximum number you can have of this item.
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "AmethystOreInv", 5);
            recipe.AddTile(mod, "AmethystFurnace");
            recipe.SetResult(mod, "AmethystBarInv", 2);
            recipe.AddRecipe();
        }
    }
}