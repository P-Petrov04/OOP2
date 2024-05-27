using ArenaGame;
using ArenaGame.Heroes;
using ArenaGame.Weapons;
using System.Runtime.CompilerServices;

namespace ConsoleArenaGame
{
    class Program
    {
        static void ConsoleNotification(GameEngine.NotificationArgs args)
        {
            Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {Math.Round(args.Attack,2)} and caused {Math.Round(args.Damage,2)} damage.");
            Console.WriteLine($"Attacker: {args.Attacker}");
            Console.WriteLine($"Defender: {args.Defender}");
        }
        static void Main(string[] args)
        {
            GameEngine gameEngine = new GameEngine()
            {
                NotificationsCallBack = ConsoleNotification
                //NotificationsCallBack = args => Console.WriteLine($"{args.Attacker.Name} attacked {args.Defender.Name} with {args.Attack} and caused {args.Damage} damage.")
            };
            gameEngine.HeroA = gameEngine.ChooseHeroForFight();
            gameEngine.HeroB = gameEngine.ChooseHeroForFight();

            gameEngine.Fight();

            Console.WriteLine();
            Console.WriteLine($"And the winner is {gameEngine.Winner}");
        }
    }
}