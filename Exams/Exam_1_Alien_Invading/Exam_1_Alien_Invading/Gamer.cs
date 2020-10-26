using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_1_Alien_Invading
{
    public class Gamer
    {
        public int Lives = 100;
        public int sizeOfAttack = 20;
        public void RemoveGamersLives(int damage)
        {
            if (Lives <= 0)
            {
                return;
            }
            else
            {
                Lives -= damage;
                return;
            }
        }
    }
}
