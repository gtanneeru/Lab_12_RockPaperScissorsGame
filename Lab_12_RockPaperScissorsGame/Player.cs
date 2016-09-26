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
        public enum Roshambo { ROCK = 1, PAPER = 2, SCISSORS = 3 }
        public abstract Roshambo generateRoshambo();
        
        //public Roshambo rockPaper(Roshambo player1, Roshambo player2)
        //{
            
        //}
        
    }
}
