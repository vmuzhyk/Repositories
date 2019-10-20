using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_4_Chu_Va_Chi
{
    class Game
    {
        private Player Human { get; }
        private Player Computer { get; }


        public Game()
        {
            Human = new Player(0);
            Computer = new Player(0);
            Console.WriteLine($"Human wins {Human.Wins} and Computer wins {Computer.Wins}");
            

        }
    }
}
