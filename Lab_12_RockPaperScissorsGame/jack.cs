using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_RockPaperScissorsGame
{
    class jack:Player

        {
        private Random r = new Random();
        Roshambo rockPlayer;
            public override Roshambo generateRoshambo()
       {
            rockPlayer = (Roshambo)r.Next(1, 2);
            Console.WriteLine(rockPlayer);
            return rockPlayer;
      }
   } 

}
