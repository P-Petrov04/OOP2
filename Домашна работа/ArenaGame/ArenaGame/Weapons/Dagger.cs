﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Dagger : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public Dagger(string name)
        {
            Name = name;
            AttackDamage = 20;
            BlockingPower = 5;
        }
    }
}
