using Exam_6_Heroes_And_Magic.Models.Abstract;
using Exam_6_Heroes_And_Magic.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic.Models
{
    class Cerberus : UnitBase
    {
        private int _numberOfTargets;
        public Cerberus(int maxHealth, int damage, string name, string teamName) : base(maxHealth, damage, name, teamName)
        {
            _numberOfTargets = 3;
        }

        public override void ReceiveHitBack(UnitBase defender)
        {
            //Console.WriteLine($" {GetInfoExtended()} avoided hit back from {defender.GetInfoBasic()}");
            return;
        }

        public override void Attack(Army defenderArmy)
        {
            var randomUnits = defenderArmy.GetRandomAliveUnits(_numberOfTargets);
            foreach(var unit in randomUnits)
                this.Attack(unit);
        }
    }
}
