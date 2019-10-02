using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2_Alien_Invading_Refactoring
{
    public class Gamer : Unit
    {
        public Gamer(int lives, int sizeOfAttack) : base(lives, sizeOfAttack)
        {

        }

        public override bool IsAlive()
        {
            if (base.IsAlive())
            {
                return true;
            } else
            {
                Console.WriteLine("Game over!!! You are LOOSER!!! Ha Ha!!!");
                return false;
            }
        }
    }
}
