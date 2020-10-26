using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic.Models.Abstract
{
    public interface IMortable
    {
        int CurrentHealth { get; set; }
        int MaxHealth { get; set; }

        bool GetIsAlive();
        void RemoveHealth(int damage);
        void RemoveHealth(UnitBase attacker);
        void ReceiveHitBack(UnitBase defender);
    }
}
