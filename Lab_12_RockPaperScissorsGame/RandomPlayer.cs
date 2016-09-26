using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_RockPaperScissorsGame
{
    class RandomPlayer : Player

    {
        static Random r = new Random();
        int randomNumber = r.Next(1, 4);
        Roshambo roshambo;

        public override Roshambo generateRoshambo()
        {

            if (randomNumber == 1)
            {
                roshambo = Player.Roshambo.ROCK;
                Console.WriteLine(roshambo);
                return roshambo;
            }
            else if (randomNumber == 2)
            {
                roshambo = Player.Roshambo.PAPER;
                Console.WriteLine(roshambo);
                return roshambo;
            }

            else if (randomNumber == 3)
            {
                roshambo = Player.Roshambo.SCISSORS;
                Console.WriteLine(roshambo);
                return roshambo;
            }
            return roshambo;
        }

            //private Random r = new Random();

            //public override Roshambo generateRoshambo()
            //{
            //  Roshambo  roshambo =(Roshambo) r.Next(1, 4);
            //    Console.WriteLine(roshambo);
            //    //string random = (string)Enum.Parse(typeof(Roshambo),random);
            // return roshambo;
            //}
            //public  Roshambo generateRoshamboPaper()
            //{
            //    Roshambo roshambo = (Roshambo)r.Next(1, 2);
            //    Console.WriteLine(roshambo);
            //    return roshambo;
            //}
            //public Roshambo generateRoshamboScissors()
            //{
            //    Roshambo roshambo = (Roshambo)r.Next(1, 3);
            //    Console.WriteLine(roshambo);
            //    return roshambo;
            //}
        }
}
