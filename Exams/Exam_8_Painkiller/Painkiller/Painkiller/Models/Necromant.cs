using Painkiller.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painkiller.Models
{
    public class Necromant : Unit
    {
        public int CriticalChance { get; }
        public Necromant(int maxHealth, int damage, string name, Team team, int criticalChance) : base(maxHealth, damage, name, team)
        {
            CriticalChance = criticalChance;
        }

        public override void Attack(IUnit defender)
        {
            MakeInfluence(defender);
            base.Attack(defender);
        }

        public override void MakeInfluence(IUnit defender)
        {
            var percent = new Random().Next(1, 101);
            if (percent > CriticalChance)
                return;
             
            defender.ReceiveInfluence(this);
        }
    }
}
 