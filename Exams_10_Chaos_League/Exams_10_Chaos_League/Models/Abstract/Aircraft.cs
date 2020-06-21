using Exams_10_Chaos_League.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exams_10_Chaos_League.Models.Abstract
{
    public abstract class Aircraft : Unit
    {
        public int Damage { get; set; }
        public Cruiser ParentCruiser { get; }
        public Aircraft(int maxHealth, int damage, Cruiser parentCruiser) : base(maxHealth)
        {
            ParentCruiser = parentCruiser;
            Damage = damage;

        }

        public override void AttackEnemy(Army enemyArmy)
        {
            Console.Write($"{this} attaked ");
        }

        public virtual void AttackEnemy(List<Cruiser> enemyCruisers)
        {
            var enemycruiser = enemyCruisers.OrderBy(x => RandomService.MakeRandom()).First();
            enemycruiser.RemoveHealth(this.Damage);
            Console.WriteLine($"{enemycruiser.Army.Name} Cruiser ({enemycruiser.CurrentHealth})");
        }
    }
}
