using Microsoft.Xna.Framework;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.ModLoader;

namespace SomeNewGoodStuffLolWeirdNameXD.Items.Placeable
{
    public class EnchantedAmethystBarInv : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Enchanted Amethyst Bar");
            Tooltip.SetDefault("Required to make better amethyst stuff.");
            }
        public override void SetDefaults()
        {
            item.width = 30; // Hitbox Width
            item.height = 25; // Hitbox Height
            item.useTime = 20; // Speed before reuse
            item.useAnimation = 20; // Animation Speed
            item.useStyle = 1; // 1 = Broadsword 
            item.value = 50; // 10 | 00 | 00 | 00 : Platinum | Gold | Silver | Bronze
            item.rare = 2; // Item Tier
            item.UseSound = SoundID.Item1; // Sound effect of item on use 
            item.autoReuse = true; // Do you want to torture people with clicking? Set to false
            item.consumable = true; // Will consume the item when placed.
            item.createTile = mod.TileType("EnchanteddAmethystBar");
            item.maxStack = 999; // The maximum number you can have of this item.   
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod, "AmethystOreInv", 1);
            recipe.AddIngredient(ItemID.HallowedBar, 1);
            recipe.AddRecipeGroup("SummonersAssociation:SoulsOf");
            recipe.AddTile(mod, "EnchancedAmethystFurnace");
            recipe.SetResult(mod, "EnchantedAmethystBarInv", 2);
            recipe.AddRecipe();
        }
    }
}