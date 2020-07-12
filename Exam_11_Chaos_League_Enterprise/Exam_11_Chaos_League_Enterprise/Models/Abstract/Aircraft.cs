using Exam_11_Chaos_League_Enterprise.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_11_Chaos_League_Enterprise.Models.Abstract
{
    public class Aircraft : Unit
    {
        private int maxHealt;
        private int damage;

        public Cruiser ParentCruiser { get; }
        public Aircraft(int maxHealt, int damage, Cruiser parentcruiser ) : base(maxHealt, damage)
        {
            ParentCruiser = parentcruiser;
        }

        
        internal override void AttackEnemy(Army enemyarmy)
        {
            Console.Write($"{this} attacked  ");
        }

        internal override void AttackEnemy(List<Cruiser> enemyCruisers)
        {
            var enemycruiser = enemyCruisers.OrderBy(unit => RandomService.Get()).FirstOrDefault();
            enemycruiser.RemoveHealth(this.Damage);
            Console.Write($"{enemycruiser.Army.Name} Cruiser ({enemycruiser.CurrentHealth}) \n");
        }
    }
}
