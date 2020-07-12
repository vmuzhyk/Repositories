using Exam_11_Chaos_League_Enterprise.Models.Abstract;
using Exam_11_Chaos_League_Enterprise.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_11_Chaos_League_Enterprise.Models
{
    public class Fighter : Aircraft
    {
        public Fighter(int maxHealt, int damage, Cruiser parentcruiser) : base(maxHealt, damage, parentcruiser)
        {
        }

        public override string ToString()
        {
            return $"F({CurrentHealth})";
        }

        internal override void AttackEnemy(Army enemyarmy)
        {
            base.AttackEnemy(enemyarmy);
            var legion = enemyarmy.AllAliveCruisers.SelectMany(cruiser => cruiser.AllAliveUnits).ToList();
            var enemy = legion.OrderBy(unit => RandomService.Get()).FirstOrDefault();
            if (ParentCruiser.AllAliveUnits.Count != null)
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
