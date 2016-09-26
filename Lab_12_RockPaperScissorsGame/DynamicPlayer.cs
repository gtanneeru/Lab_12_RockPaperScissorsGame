using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_RockPaperScissorsGame
{
    class DynamicPlayer : Player
    {
        Roshambo roshambo;
        public override Roshambo generateRoshambo()
        {
            return roshambo;
        }
        public Roshambo generateRoshambo(int randomPlayerChoice)
            
        {
             Roshambo rps = 0;
           // Console.WriteLine("Enter Rock(1), Paper(2), Scissors(3)");
           // bool whenValidNumber = int.TryParse(Console.ReadLine(), out randomPlayerChoice);

            if (randomPlayerChoice == 1)
               {
                rps = Player.Roshambo.ROCK;
                Console.WriteLine(rps);
                return rps;


            }
            if (randomPlayerChoice == 2)
            {
                rps = Player.Roshambo.PAPER;
                Console.WriteLine(rps);
                return rps;
            }

            if (randomPlayerChoice == 3)
            {
                rps = Player.Roshambo.SCISSORS;
                Console.WriteLine(rps);
                return rps;
            }
            return rps;
        }


    }
}
