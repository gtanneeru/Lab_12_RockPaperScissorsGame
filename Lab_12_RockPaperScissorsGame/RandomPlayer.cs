using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_RockPaperScissorsGame
{
    class RandomPlayer : Player

    {
        private Random r = new Random();
        public override Roshambo generateRoshambo( Roshambo roshambo)
        {
            roshambo =(Roshambo) r.Next(1, 4);
            //string random = (string)Enum.Parse(typeof(Roshambo),random);
         return roshambo;
        }
    }
}
