using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam_6_Heroes_And_Magic.Models.Abstract;

namespace Exam_6_Heroes_And_Magic.Models
{
    public class Elf : UnitBase
    {
        public Elf(int maxHealth, int damage, string name, Army team) : base(maxHealth, damage, name, team)
        {
        }

        public override void ReceiveHitBack(UnitBase defender)
        {
           
        }
    }
}
