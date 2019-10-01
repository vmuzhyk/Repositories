using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2_Alien_Invading_Refactoring
{
    public abstract class Unit
    {
        public int SizeOfAttack { get; private set; }
        public int Lives { get; private set; }

        public Unit(int lives, int sizeOfAttack)
        {
            Lives = lives;
            SizeOfAttack = sizeOfAttack;
        }

        public void RemoveLives(int damage)
        {
            
            if (Lives > 0)
            {
                Lives -= damage;
            }
        }

        public bool IsAlive()
        {
            return Lives > 0;
        }

    }
}
