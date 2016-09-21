using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_RockPaperScissorsGame
{
    class Program
    {
        
        static void Main(string[] args)
        {
            RandomPlayer randomPlayer = new RandomPlayer();
            jack alwaysRock = new jack();
            DynamicPlayer ConsolePlayer = new DynamicPlayer();
            
            string name = " ";
            string yes = " ";
            //int count = 0;
           // int consolePlayerChoice = 0;

            Console.WriteLine("welcome to rock paper scissors!");
            Console.WriteLine("what is your name?");
            name = Console.ReadLine();
            do {
                Console.WriteLine("Would you like to play againest TheJets or TheSharks(j/s)?:");
                string computerPlayer = Console.ReadLine().ToLower();



                if (computerPlayer == "j")
                {

                    if (ConsolePlayer.generateRoshambo(Player.Roshambo.ROCK) == Player.Roshambo.ROCK)
                    {
                        Console.WriteLine(name + ": ROCK");
                        Console.WriteLine("TheJets: ROCK");

                        Console.WriteLine("DRAW");

                    }
                    else if (ConsolePlayer.generateRoshambo(Player.Roshambo.PAPER) == Player.Roshambo.ROCK)
                    {
                        Console.WriteLine(name + ": PAPER");
                        Console.WriteLine("TheJets: ROCK");
                        Console.WriteLine("You WIN");
                    }
                    else if (ConsolePlayer.generateRoshambo(Player.Roshambo.SCISSORS) == Player.Roshambo.ROCK)
                    {
                        Console.WriteLine(name + ": SCISSORS");
                        Console.WriteLine("TheJets: ROCK");
                        Console.WriteLine("TheJets WON");
                    }
                }

                else if (computerPlayer == "s")
                {
                    if (ConsolePlayer.generateRoshambo(Player.Roshambo.ROCK) == randomPlayer.generateRoshambo())

                }
                Console.WriteLine("Want to play again! (y/n)");
                yes = Console.ReadLine()
           } while (yes == "y");


                            
                

;
            


            //else if (computerPlayer == "s")
            //{
            //    Console.WriteLine(randomPlayer.generateRoshambo());

            //}

           
            Console.ReadKey();
        }
    }
}
