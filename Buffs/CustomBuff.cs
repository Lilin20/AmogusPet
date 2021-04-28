using Terraria;
using Terraria.ModLoader;

namespace AmogusPet.Buffs
{
    public class CustomBuff : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Amogus");
            Description.SetDefault("When the impostor is sus!");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.GetModPlayer<MyPlayer>();
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<MyPlayer>().Pet = true;
            bool petProjectileNotSpawned = player.ownedProjectileCounts[mod.ProjectileType("CustomPet")] <= 0;
            if (petProjectileNotSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X + (float)(player.width / 2), player.position.Y + (float)(player.height / 2), 0f, 0f, mod.ProjectileType("CustomPet"), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}