﻿using ArenaGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Assassin : Hero
    {
        public Assassin(string name, double armor, double strenght, IWeapon weapon) : 
            base(name, armor, strenght, weapon)
        {
        }

        public override double Attack()
        {
            double damage = base.Attack();

            double probability = random.NextDouble();
            if (probability < 0.40) //Dagger Ability
            {
                damage *= 3;
            }
            return damage;
        }
    }
}
