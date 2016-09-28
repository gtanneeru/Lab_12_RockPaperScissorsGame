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
        

        public override Roshambo generateRoshambo(int num)
        {
            
            switch (num)
            {
                case 1:
                    roshambo = Player.Roshambo.ROCK;
                    //Console.WriteLine("You chose: " +rps);
                    break;

                case 2:
                    roshambo = Player.Roshambo.PAPER;
                    //Console.WriteLine("You chose: " + rps);
                    break;
                case 3:
                    roshambo = Player.Roshambo.SCISSORS;
                    //Console.WriteLine("You chose: " + rps);
                    break;
                default:
                    break;
            }
            return roshambo;
        }
    }
}
