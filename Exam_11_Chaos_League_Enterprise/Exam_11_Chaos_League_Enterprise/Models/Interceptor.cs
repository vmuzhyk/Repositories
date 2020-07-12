using Exam_11_Chaos_League_Enterprise.Models.Abstract;
using Exam_11_Chaos_League_Enterprise.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_11_Chaos_League_Enterprise.Models
{
    public class Interceptor : Aircraft
    {
        public Interceptor(int maxHealt, int damage, Cruiser parentcruiser) : base(maxHealt, damage, parentcruiser)
        {
        }
        public override string ToString()
        {
            return $"I({CurrentHealth})";
        }

        internal override void AttackEnemy(Army enemyarmy)
        {
            base.AttackEnemy(enemyarmy);
            var legion = enemyarmy.AllAliveCruisers.SelectMany(cruiser => cruiser.AllAliveUnits).ToList();
            var enemy = legion.OrderBy(unit => unit.CurrentHealth/unit.MaxHealth*100).ThenByDescending(unit => MaxHealth).ThenBy((unit => RandomService.Get())).FirstOrDefault();
            if (enemy != null)
            {
                enemy.RemoveHealth(this.Damage);
                Console.Write($"{ParentCruiser.Army.Name} {enemy} \n");
            }
            else
            {
                AttackEnemy(enemyarmy.AllAliveCruisers);
            }
            
        }
    }
}
