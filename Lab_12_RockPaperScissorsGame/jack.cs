using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_RockPaperScissorsGame
{
    class jack:Player
      {
        Roshambo rockPlayer;
        private Random r = new Random();
       public override Roshambo generateRoshambo(int num)
       {
            num = r.Next(1, 2);
            rockPlayer = (Roshambo)num;
            Console.WriteLine(rockPlayer);
            return rockPlayer;
      }
   } 

}
