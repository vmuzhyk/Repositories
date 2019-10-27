using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_4_Chu_Va_Chi
{
    public class Player
    {
        public int WinsCount { get; set; }
        public int DrawCount { get; set; }
        public Elements Choice { get; set; }

        
        public override string ToString()
        {
            return $"Wins: {WinsCount}, Draw: {DrawCount}";
        }
    }
}
