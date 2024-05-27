using ArenaGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Barbarian : Hero
    {
        private bool isBerserkModeActive = false;
        public Barbarian(string name, double armor, double strenght, IWeapon weapon) 
            : base(name, armor, strenght, weapon)
        {
        }

        public override double Attack()
        {
            double damage = base.Attack();

            if(this.Health <= 40 && isBerserkModeActive == false) //Battle Axe ability
            {
                damage += damage * 2;
            }

            return damage;
        }
    }
}
