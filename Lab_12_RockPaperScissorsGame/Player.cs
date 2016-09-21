using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_RockPaperScissorsGame
{
   abstract class Player
    {
        string name = "";
       public enum Roshambo { ROCK=1, PAPER, SCISSORS}
       public abstract Roshambo generateRoshambo(Roshambo xyz);
        

        
    }
}
