using Exam_11_Chaos_League_Enterprise.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_11_Chaos_League_Enterprise.Models
{
    public class Bomber : Aircraft
    {
        public Bomber(int maxHealt, int damage, Cruiser parentcruiser) : base(maxHealt, damage, parentcruiser)
        {
        }

        public override string ToString()
        {
            return $"B({CurrentHealth})";
        }

        internal override void AttackEnemy(Army enemyarmy)
        {
            base.AttackEnemy(enemyarmy);
            AttackEnemy(enemyarmy.AllAliveCruisers);
        }
    }
}
