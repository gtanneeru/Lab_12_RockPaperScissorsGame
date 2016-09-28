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
        Roshambo rosh;
        public enum Roshambo { ROCK = 1, PAPER = 2, SCISSORS = 3 }
        public abstract Roshambo generateRoshambo( int n);

        }
    
        
  }

