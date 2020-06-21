using Exams_10_Chaos_League.Models.Abstract;
using Exams_10_Chaos_League.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exams_10_Chaos_League.Models
{
    public class Fighter : Aircraft
    {
        public Fighter(int maxHealth, int damage, Cruiser parent) : base(maxHealth, damage, parent)
        {
        }

        public override string ToString()
        {
            return $"F({CurrentHealth}) ";
        }

        public override void AttackEnemy(Army enemyArmy)
        {
            base.AttackEnemy(enemyArmy);
            var enemyUnit = enemyArmy.AllAliveCruisers.SelectMany(cruiser => cruiser.AllAliveAircraft).OrderBy(x => RandomService.MakeRandom()).FirstOrDefault();
            if (enemyUnit != null)
            {
                enemyUnit.RemoveHealth(this.Damage);
                Console.WriteLine($"{enemyUnit.ParentCruiser.Army.Name} {enemyUnit}");
            }
            else
            {
                AttackEnemy(enemyArmy.AllAliveCruisers);
            }
        }
    }
}
