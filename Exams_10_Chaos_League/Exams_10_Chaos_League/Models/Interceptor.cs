using Exams_10_Chaos_League.Models.Abstract;
using Exams_10_Chaos_League.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exams_10_Chaos_League.Models
{
    public class Interceptor : Aircraft
    {
        public Interceptor(int maxHealth, int damage, Cruiser parent) : base(maxHealth, damage, parent)
        {
        }
        public override string ToString()
        {
            return $"I({CurrentHealth}) ";
        }

        public override void AttackEnemy(List<Cruiser> enemyCruisers)
        {
            var enemycruiser = enemyCruisers.OrderBy(x => x.CurrentHealth).First();
            enemycruiser.RemoveHealth(this.Damage);
            Console.WriteLine($"{enemycruiser.Army.Name} Cruiser ({enemycruiser.CurrentHealth})");
        }

        public override void AttackEnemy(Army enemyArmy)
        {
            base.AttackEnemy(enemyArmy);
            var enemyUnit = enemyArmy.AllAliveCruisers
                .SelectMany(cruiser => cruiser.AllAliveAircraft)
                .OrderBy(x => x.CurrentHealth / x.MaxHealth * 100)
                .ThenByDescending(x => x.MaxHealth)
                .ThenBy(x => RandomService.Get())
                .FirstOrDefault();


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
