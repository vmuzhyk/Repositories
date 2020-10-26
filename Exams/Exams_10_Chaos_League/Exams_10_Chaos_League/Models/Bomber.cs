using Exams_10_Chaos_League.Models.Abstract;
using Exams_10_Chaos_League.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exams_10_Chaos_League.Models
{
    public class Bomber : Aircraft
    {
        public Bomber(int maxHealth, int damage, Cruiser parent) : base(maxHealth, damage, parent)
        {
        }

        public override string ToString()
        {
            return $"B({CurrentHealth}) ";
        }

        public override void AttackEnemy(Army enemyArmy)
        {
            base.AttackEnemy(enemyArmy);
            AttackEnemy(enemyArmy.AllAliveCruisers);
        }
    }
}
