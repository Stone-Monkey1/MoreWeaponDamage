
using MoreWeaponDamage;

namespace CalculateDamage
{
    internal class SwordDamage : WeaponDamage
    {
        private const int BASE_DAMAGE = 3;
        private const int FLAME_DAMAGE = 2;

        public SwordDamage(int startingRoll) : base(startingRoll) { }

        protected override void CalculateDamage()
        {
            decimal MagicMultiplier = 1M;
            if (Magic)
            {
                MagicMultiplier = 1.75M;
            }
            Damage = BASE_DAMAGE;
            Damage = (int)(Roll * MagicMultiplier) + BASE_DAMAGE;
            if (Flaming)
            {
                Damage += FLAME_DAMAGE;
            }
        }
    }
}
