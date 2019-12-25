using Exam_6_Heroes_And_Magic.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic.Models
{
    class Crusader : UnitBase
    {
        public Crusader(int maxHealth, int damage, string name, string teamName) : base(maxHealth, damage, name, teamName)
        {
        }

        public override void Attack(UnitBase defender)
        {
            base.Attack(defender);
            if ((!IsAlive) || (!defender.IsAlive))
                return;

            defender.RemoveHealth(this.Damage);
            Console.WriteLine($" {defender.GetInfoExtended()} after second attack from {GetInfoBasic()}");

        }
    }
}
