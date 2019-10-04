using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_3_Kung_Fu_Hall
{
    class Fighter
    {
        public int SizeOfAttack { get; private set; }
        public int Lives { get; private set; }

        public Fighter (int lives, int sizeOfAttack)
        {
            Lives = lives;
            SizeOfAttack = sizeOfAttack;
        }

        public void RemoveLives(int damage)
        {
            if (Lives <= 0)
                return;

            Lives -= damage;
        }

        public bool IsAlive()
        {
            return Lives > 0;
        }


        public void AvoidBeingHit()
        {

        }
    }
}
