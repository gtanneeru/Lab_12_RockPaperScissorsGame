using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_RockPaperScissorsGame
{
    class DynamicPlayer: Player
    {
        private Random r = new Random();

        public override Roshambo generateRoshambo(Roshambo dynamicChoice)
        {
            string yes = "";
            int randomPlayerChoice = 0;
            Console.WriteLine("Enter Rock(1), Paper (2), Scissors(3)");
            bool Choice = Int32.TryParse(Console.ReadLine(), out randomPlayerChoice);

            do
            {
                if (randomPlayerChoice == 1)
                {
                     dynamicChoice = Roshambo.ROCK;
                    return dynamicChoice;
                }
                else if (randomPlayerChoice == 2)
                {
                     dynamicChoice = Roshambo.PAPER;
                    return dynamicChoice;
                }
                else if (randomPlayerChoice == 3)
                {
                     dynamicChoice = Roshambo.SCISSORS;
                    return dynamicChoice;
                }
                else if (randomPlayerChoice != 1 || randomPlayerChoice != 2 || randomPlayerChoice != 3)
                {
                    Console.WriteLine("Please Enter a valid Number");
                    Console.WriteLine("Would you like to play again? (y/n)");
                    yes = Console.ReadLine();
                }
            } while (yes == "y");
            return dynamicChoice;
        }
        
    }
}
