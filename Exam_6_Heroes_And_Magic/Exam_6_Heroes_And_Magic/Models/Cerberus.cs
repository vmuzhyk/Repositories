using Exam_6_Heroes_And_Magic.Models.Abstract;
using Exam_6_Heroes_And_Magic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic.Models
{
    class Cerberus : MeleeUnitBase
    {
        public Cerberus(int maxHealth, int damage, string name, string teamName) : base(maxHealth, damage, name, teamName)
        {
        }

        public override void ReceiveHitBack(MeleeUnitBase defender)
        {
            Console.WriteLine($" {GetInfoExtended()} avoided hit back from {defender.GetInfoBasic()}");
            return;
        }

        public override void Attack(Army defenderArmy)
        {
            var randomUnits = defenderArmy.GetRandomAliveUnit(3);
            foreach(var unit in randomUnits)
                this.Attack(unit);
        }
    }
}
