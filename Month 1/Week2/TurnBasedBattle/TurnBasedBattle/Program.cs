using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBasedBattle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello and welcome, again this is rhouge with my 2nd week of learning programming");
            Console.WriteLine("using C# and today, I made a 2 player turn-based battle game");
            Console.WriteLine("this time, I searched for a turn-based battle game and improvised it");
            Console.WriteLine("Let's Start!");

            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine("                            Turn-Based Battle Game");
            Console.WriteLine("--------------------------------------------------------------------------------");

            Unit player = new Unit(100, 20, 12, "player");
            Unit player2 = new Unit(80, 25, 10, "player 2");

            while (!player.isDead && !player2.isDead)
            {
                Console.WriteLine("");
                Console.WriteLine($"{player.character} HP = {player.Hp} \t {player2.character} HP = {player2.Hp}");
                Console.WriteLine("");
                Console.Write("Player 1 turn! what will you do (A = Attack, B = Heal): ");
                string choice = Console.ReadLine().ToUpper();

                if (choice == "A")
                {
                    player.Attack(player2);
                }
                else
                {
                    player.Heal();
                }

                Console.WriteLine("");
                Console.WriteLine($"{player.character} HP = {player.Hp} \t {player2.character} HP = {player2.Hp}");
                Console.WriteLine("");

                if (player.isDead || player2.isDead)

                Console.WriteLine("");
                Console.Write("Player 2 turn! what will you do? (A = Attack, B = Heal): ");
                string choice2 = Console.ReadLine().ToUpper();

                if (choice2 == "A")
                {
                    player2.Attack(player);
                }
                else
                {
                    player2.Heal();
                }
            }
            Console.ReadLine();
        }
    }
}
