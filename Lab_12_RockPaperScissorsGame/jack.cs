using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_RockPaperScissorsGame
{
    class jack : Player
    {
        private Random r = new Random();
        public override Roshambo generateRoshambo(Roshambo ROCK)
        {
            Roshambo rockPlayer = (Roshambo)r.Next(1,1);
            return ROCK;
           
        }
    }
}
