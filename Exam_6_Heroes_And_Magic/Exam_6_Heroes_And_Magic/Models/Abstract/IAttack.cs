using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic.Models.Abstract
{
    public interface IAttack
    {
        int Damage { get; set; }
        void Attack(UnitBase defender);
        void Attack(Army defenderArmy);
        void HitBack(UnitBase attacker);
    }

}
