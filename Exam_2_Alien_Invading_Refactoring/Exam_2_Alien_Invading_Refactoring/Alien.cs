using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2_Alien_Invading_Refactoring
{
    public class Alien : Unit
    {
        public int Id { get; private set; }
        
        public Alien(int lives, int sizeOfAttack, int id) : base(lives, sizeOfAttack)
        {
            Id = id;
        }
    }
}
