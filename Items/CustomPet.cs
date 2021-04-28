using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AmogusPet.Items
{
    class CustomPet : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Amogus");
            Tooltip.SetDefault("You acting kinda sus");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.UnluckyYarn);
            item.shoot = mod.ProjectileType("CustomPet");
            item.buffType = mod.BuffType("CustomBuff");
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/amogus");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock, 1000);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this);
            recipe  .AddRecipe();
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(item.buffTime, 3600, true);
            }
        }
    }
}