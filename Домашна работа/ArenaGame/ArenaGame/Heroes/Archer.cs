using ArenaGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Archer : Hero
    {
        private bool isCritStrike = false;
        public Archer(string name, double armor, double strenght, IWeapon weapon) 
            : base(name, armor, strenght, weapon)
        {
        }

        public override double Attack()
        {
            double damage = base.Attack();

            if(random.NextDouble() < 0.30)
            {
                isCritStrike = true;
            }
            if (isCritStrike) //Bow Ability (Head shot)
            {
                damage *= 10;
            }

            return damage;
        }
    }
}
