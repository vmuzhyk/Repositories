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
        public Necromant (int maxHealth, int damage, string name, Team team, int criticalChance) : base(maxHealth, damage, name, team)
        {
        }

        public override void Attack(IUnit defender)
        {
            base.Attack(defender);
        }
    }
}
 