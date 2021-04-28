using Terraria.ModLoader;

namespace AmogusPet
{
    public class MyPlayer : ModPlayer
    {
        private const int saveVersion = 0;
        public bool minionName = false;
        public bool Pet = false;
        public static bool hasProjectile;

        public override void ResetEffects()
        {
            minionName = false;
            Pet = false;
        }
    }
}