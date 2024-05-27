using ArenaGame.Heroes;
using ArenaGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame
{
    public class GameEngine
    {
        public class NotificationArgs
        {
            public Hero Attacker { get; set; }
            public Hero Defender { get; set; }
            public double Attack { get; set; }
            public double Damage { get; set; }
        }

        public delegate void GameNotifications(NotificationArgs args);

        private Random random = new Random();
        public Hero HeroA { get; set; }
        public Hero HeroB { get; set; }
        public Hero Winner { get; set; }
        public GameNotifications? NotificationsCallBack { get; set; }
        public void Fight()
        {
            Hero attacker;
            Hero defender;

            double probability = random.NextDouble();
            if (probability < 0.5)
            {
                attacker = HeroA;
                defender = HeroB;
            } else
            {
                attacker = HeroB;
                defender = HeroA;
            }

            while (attacker.IsAlive)
            {
                double attack = attacker.Attack();
                double actualDamage = defender.Defend(attack);

                if (NotificationsCallBack != null)
                {

                    NotificationsCallBack(new NotificationArgs()
                    {
                        Attacker = attacker,
                        Defender = defender,
                        Attack = attack,
                        Damage = actualDamage
                    }); 
                }

                Hero tempHero = attacker;
                attacker = defender;
                defender = tempHero;
            }
            Winner = defender;
        }

        public Hero ChooseHeroForFight()
        {
            int heroNum = random.Next(1, 5);
            if(heroNum == 1)
            {
                return new Assassin("Assassin", 10, 5, new Dagger("Dagger"));
            }
            else if(heroNum == 2)
            {
                return new Archer("Archer", 5, 10, new Bow("Bow"));
            }
            else if(heroNum == 3)
            {
                return new Barbarian("Barbarian", 10, 15, new BattleAxe("Axe"));
            }

            int numForWeapon = random.Next(1, 3);
            if(numForWeapon == 1)
            {
                return new Knight("Knight", 10, 20, new Sword("Sword"));
            }

            return new Knight("Knight", 10, 20, new Mace("Mace"));
        }
    }
}
