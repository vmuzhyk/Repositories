using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_4_Chu_Va_Chi
{
    class Game
    {
        public Game()
        {   Round round = new Round();

            while (!round.BeginRound()) { }
            Console.WriteLine("Game over");
           
        }
    }
}
