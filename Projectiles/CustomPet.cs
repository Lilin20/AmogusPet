using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace AmogusPet.Projectiles
{
    public class CustomPet : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.BlackCat);
            projectile.Name = "When the impostor is sus!";
            aiType = ProjectileID.BabyHornet;
            Main.projFrames[projectile.type] = 1;
            Main.projPet[projectile.type] = true;
        }

        public override bool PreAI()
        {
            Player player = Main.player[projectile.owner];
            player.blackCat = false;
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            MyPlayer modPlayer = player.GetModPlayer<MyPlayer>();
            if (player.dead)
            {
                modPlayer.Pet = false;
            }

            if (modPlayer.Pet)
            {
                projectile.timeLeft = 2;
            }
        }

    }
}
