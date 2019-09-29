using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_1_Alien_Invading
{
    public class Alien
    {
        public int Lives = 15;
        public int sizeOfAttack = 10;

        public override string ToString()
        {
            var output = "Lives "+ Lives;
            return output;
        }
        public void RemoveLives(int damage)
        {
            if (Lives <= 0)
            {
                return;
            } else
            {
                Lives -= damage;
                return;
            }
        }
    }   
}
