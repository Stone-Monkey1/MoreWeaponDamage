using System;
using System.Collections.Generic;
using System.Text;

namespace MoreWeaponDamage
{
    internal class WeaponDamage
    {
        public int Damage { get; protected set; }
        public int roll;
        public bool flaming;
        public bool magic;

        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }



        public bool Flaming { get { return flaming; } set { flaming = value; CalculateDamage(); } }

        public bool Magic { get { return magic; } set { magic = value; CalculateDamage(); } }


        public WeaponDamage(int startingRoll)
        {
            roll = startingRoll;
            CalculateDamage();
        }

        protected virtual void CalculateDamage()
        {
            Console.WriteLine("This wasn't overwritten for some reason");
        }

    }
}
