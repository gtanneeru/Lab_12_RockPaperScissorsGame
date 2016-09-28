using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_RockPaperScissorsGame
{
    class RandomPlayer : Player

    {
        
        public override Roshambo generateRoshambo(int randomNumber)
        {
             Roshambo roshambo =0;
            if (randomNumber == 1)
            {
                roshambo = Player.Roshambo.ROCK;
                //Console.WriteLine("TheSharks: "+roshambo);
                return roshambo;
            }
            else if (randomNumber == 2)
            {
                roshambo = Player.Roshambo.PAPER;
               // Console.WriteLine("TheSharks: " + roshambo);
                return roshambo;
            }

            else if (randomNumber == 3)
            {
                roshambo = Player.Roshambo.SCISSORS;
               // Console.WriteLine("TheSharks: " + roshambo);
                return roshambo;
            }
            return  roshambo;
        }
    }
}
