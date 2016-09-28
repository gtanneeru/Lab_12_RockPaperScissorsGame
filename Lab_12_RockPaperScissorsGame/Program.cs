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

            int playerCount = 0;
            int computerCount = 0;
            string name = " ";
            string wantToPlay = "";
            int playerChoice;


            Console.WriteLine("welcome to rock paper scissors!");
            Console.WriteLine("what is your name?");
            name = Console.ReadLine();
            do
            {
                Console.WriteLine("Would you like to play againest TheJets or TheSharks(j/s)?:");
                string computerPlayer = Console.ReadLine().ToLower();

                if (computerPlayer == "j" || computerPlayer == "thejets")
                {
                    Console.WriteLine("\nEnter Rock(1), Paper (2), Scissors(3)");
                    bool Choice = Int32.TryParse(Console.ReadLine(), out playerChoice);
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
                        playerCount++;
                        Console.WriteLine("{0}:PAPER", name);
                        Console.WriteLine("TheJets:ROCK");
                        Console.WriteLine("{0} WON", name);
                        Console.WriteLine("Want to play again?(y/n)");
                        wantToPlay = Console.ReadLine();
                    }
                    else if (playerChoice == 3)
                    {
                        computerCount++;
                        Console.WriteLine("{0}:SCISSORS", name);
                        Console.WriteLine("TheJets:ROCK");
                        Console.WriteLine("TheJets Won");
                        Console.WriteLine("Want to play again?(y/n)");
                        wantToPlay = Console.ReadLine();
                    }
                    else
                        Console.WriteLine("Please Enter a valid number");
                }


                if (computerPlayer == "s" || computerPlayer == "thesharks")

                {
                    int randomPlayerChoice;
                    Console.WriteLine("Enter Rock(1), Paper(2), Scissors(3)");
                    bool whenValidNumber = int.TryParse(Console.ReadLine(), out randomPlayerChoice);
                    Random r = new Random();
                    int randomNumber = r.Next(1, 4);

                    if (ConsolePlayer.generateRoshambo(randomPlayerChoice) != Player.Roshambo.PAPER && ConsolePlayer.generateRoshambo(randomPlayerChoice) != Player.Roshambo.ROCK)
                    {
                        Console.WriteLine(name + ": SCISSORS");
                        Console.WriteLine("TheSharks:" + randomPlayer.generateRoshambo(randomNumber));

                        if (randomPlayer.generateRoshambo(randomNumber) == Player.Roshambo.ROCK)
                        {
                            computerCount++;
                            Console.WriteLine("TheSharks WON");
                            Console.WriteLine("Want to play again! (y/n)");
                            wantToPlay = Console.ReadLine().ToLower();
                        }
                        else if (randomPlayer.generateRoshambo(randomNumber) == Player.Roshambo.PAPER)
                        {
                            playerCount++;
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
                    else if (ConsolePlayer.generateRoshambo(randomPlayerChoice) != Player.Roshambo.PAPER && ConsolePlayer.generateRoshambo(randomPlayerChoice) != Player.Roshambo.SCISSORS)
                    {
                        Console.WriteLine(name + ": ROCK");
                        Console.WriteLine("TheSharks:" + randomPlayer.generateRoshambo(randomNumber));
                        if (randomPlayer.generateRoshambo(randomNumber) == Player.Roshambo.PAPER)
                        {
                            computerCount++;
                            Console.WriteLine("TheSharks WON");
                            Console.WriteLine("Want to play again! (y/n)");
                            wantToPlay = Console.ReadLine().ToLower();
                        }
                        else if (randomPlayer.generateRoshambo(randomNumber) == Player.Roshambo.SCISSORS)
                        {
                            playerCount++;
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
                    else if (ConsolePlayer.generateRoshambo(randomPlayerChoice) != Player.Roshambo.SCISSORS && ConsolePlayer.generateRoshambo(randomPlayerChoice) != Player.Roshambo.ROCK)
                    {
                        Console.WriteLine(name + ": PAPER");
                        Console.WriteLine("TheSharks: " + randomPlayer.generateRoshambo(randomNumber));
                        if (randomPlayer.generateRoshambo(randomNumber) == Player.Roshambo.ROCK)
                        {
                            playerCount++;
                            Console.WriteLine("{0} WON", name);
                            Console.WriteLine("Want to play again! (y/n)");
                            wantToPlay = Console.ReadLine().ToLower();
                        }
                        else if (randomPlayer.generateRoshambo(randomNumber) == Player.Roshambo.SCISSORS)
                        {
                            computerCount++;
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
            Console.WriteLine("\n\n Who is The Champian:");
            Console.WriteLine(name + "'s Won:\t" + playerCount);
            Console.WriteLine("Computer Won:\t" + computerCount);
            Console.ReadKey();
        }
    }
}


