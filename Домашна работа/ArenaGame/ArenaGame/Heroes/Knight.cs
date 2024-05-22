using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Knight: Hero
    {
        private Random didAbilityWillBeActivated = new Random();
        private int abilityUseCount = 0;
        private double hitCount;
        private double damageCoef;
        public Knight(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
            hitCount = 0;
            damageCoef = 0.6;
        }

        public override double Attack()
        {
            double damage = base.Attack();
            if (damageCoef < 1 && Weapon.GetType().Name == "Sword") //Sword Ability
            {
                damageCoef += 0.1; 
                damage = damage * damageCoef;
            }
            else if (didAbilityWillBeActivated.Next(0, 2) == 1 && Weapon.GetType().Name == "Mace" && abilityUseCount < 1) //Mace Ability
            {
                abilityUseCount++;
                damage += (this.Attack() / 2);
            }
            return damage;
        }

        public override double Defend(double damage)
        {
            hitCount++;
            if (hitCount == 3)
            {
                hitCount = 0;
                return 0;
            }
            return base.Defend(damage);
        }
    }
}
