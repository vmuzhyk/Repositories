using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_4_Chu_Va_Chi
{
    class Player
    {
        public Elements Choice { get; set; }
        public int WinsCount { get; set; }

        public Player(int wins)
        {
            WinsCount = wins;
        }

    }
}
