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
            string wantToPlay = "";
            //int count = 0;
            int playerChoice;


            Console.WriteLine("welcome to rock paper scissors!");
            Console.WriteLine("what is your name?");
            name = Console.ReadLine();
            do
            {
                Console.WriteLine("Would you like to play againest TheJets or TheSharks(j/s)?:");
                string computerPlayer = Console.ReadLine().ToLower();
                Console.WriteLine("You chose {0}", computerPlayer);
                Console.WriteLine("\nEnter Rock(1), Paper (2), Scissors(3)");
                bool Choice = Int32.TryParse(Console.ReadLine(), out playerChoice);


                while (computerPlayer == "j")
                {
                    if (playerChoice == 1)
                    {
                        Console.WriteLine("{0}:ROCK", name);
                        Console.WriteLine("TheJets:ROCK");
                        Console.WriteLine("DRAW");
                        Console.WriteLine("Want to play again?(y/n)");
                        wantToPlay = Console.ReadLine().ToLower();

                    }

                    else if (playerChoice == 2)
                    {
                        Console.WriteLine("{0}:PAPER", name);
                        Console.WriteLine("TheJets:ROCK");
                        Console.WriteLine("{0} WON", name);
                        Console.WriteLine("Want to play again?(y/n)");
                        wantToPlay = Console.ReadLine();
                    }
                    else if (playerChoice == 3)
                    {
                        Console.WriteLine("{0}:SCISSORS", name);
                        Console.WriteLine("TheJets:ROCK");
                        Console.WriteLine("TheJets Won");
                        Console.WriteLine("Want to play again?(y/n)");
                        wantToPlay = Console.ReadLine();
                    }
                    else
                        Console.WriteLine("Please Enter a valid number");
                }


              while (computerPlayer == "s")
                {
                    
                    if (ConsolePlayer.generateRoshambo() != Player.Roshambo.ROCK && ConsolePlayer.generateRoshambo() != Player.Roshambo.PAPER)
                    {
                        Console.WriteLine(name + ": SCISSORS");
                        Console.WriteLine("TheSharks:" + randomPlayer.generateRoshambo());
                        if (randomPlayer.generateRoshambo() == Player.Roshambo.ROCK)
                        {
                            Console.WriteLine("TheSharks WON");
                            Console.WriteLine("Want to play again! (y/n)");
                            wantToPlay = Console.ReadLine().ToLower();
                        }
                        else if (randomPlayer.generateRoshambo() == Player.Roshambo.PAPER)
                        {
                            Console.WriteLine("{0} WON", name);
                            Console.WriteLine("Want to play again! (y/n)");
                            wantToPlay = Console.ReadLine().ToLower();
                        }
                        else
                        {
                            Console.WriteLine("DRAW");
                            Console.WriteLine("Want to play again! (y/n)");
                            wantToPlay = Console.ReadLine().ToLower();
                        }
                    }
                    else if (ConsolePlayer.generateRoshambo() != Player.Roshambo.PAPER && ConsolePlayer.generateRoshambo() != Player.Roshambo.SCISSORS)
                    {
                        Console.WriteLine(name + ": ROCK");
                        Console.WriteLine("TheSharks:" + randomPlayer.generateRoshambo());
                        if (randomPlayer.generateRoshambo() == Player.Roshambo.PAPER)
                        {
                            Console.WriteLine("TheSharks WON");
                            Console.WriteLine("Want to play again! (y/n)");
                            wantToPlay = Console.ReadLine().ToLower();
                        }
                        else if (randomPlayer.generateRoshambo() == Player.Roshambo.SCISSORS)
                        {

                            Console.WriteLine("{0} WON", name);
                            Console.WriteLine("Want to play again! (y/n)");
                            wantToPlay = Console.ReadLine().ToLower();
                        }
                        else
                        {
                            Console.WriteLine("DRAW");
                            Console.WriteLine("Want to play again! (y/n)");
                            wantToPlay = Console.ReadLine().ToLower();
                        }

                        }
                    else if (ConsolePlayer.generateRoshambo() != Player.Roshambo.SCISSORS && ConsolePlayer.generateRoshambo() != Player.Roshambo.ROCK)
                    {
                        Console.WriteLine(name + ": PAPER");
                        Console.WriteLine("TheSharks: " + randomPlayer.generateRoshambo());
                        if (randomPlayer.generateRoshambo() == Player.Roshambo.ROCK)
                        {
                            Console.WriteLine("{0} WON", name);
                            Console.WriteLine("Want to play again! (y/n)");
                            wantToPlay = Console.ReadLine().ToLower();
                        }
                        else if (randomPlayer.generateRoshambo() == Player.Roshambo.SCISSORS)
                        {
                            Console.WriteLine("TheSharks WON");
                            Console.WriteLine("Want to play again! (y/n)");
                            wantToPlay = Console.ReadLine().ToLower();
                        }
                        else
                        {
                            Console.WriteLine("DRAW");
                            Console.WriteLine("Want to play again! (y/n)");
                            wantToPlay = Console.ReadLine().ToLower();
                        }
                      }

                }
                
            }
            while (wantToPlay == "y");
        }
    }
}


