using Exam_11_Chaos_League_Enterprise.Models.Abstract;
using Exam_11_Chaos_League_Enterprise.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam_11_Chaos_League_Enterprise.Models
{
    public class Cruiser : Unit
    {
        public List<Aircraft> Fleet;
        public int CanonDamage { get; set; }
        public int RandomDamage { get => RandomService.Get(20, 36); }
        public Army Army { get; }
        public List<Aircraft> AllAliveUnits => Fleet.Where(unit => unit.IsAlive).ToList();
        public Cruiser(int maxHealt, int damage, Army army, int canonDamage) : base(maxHealt, damage)
        {
            Army = army;
            CanonDamage = canonDamage;
            Fleet = new List<Aircraft>()
            {
                new Fighter(8,2, this),
                new Fighter(8,2, this),
                new Fighter(8,2, this),
                new Fighter(8,2, this),
                new Bomber(6,12, this),
                new Bomber(6,12, this),
                new Bomber(6,12, this),
                new Interceptor(4,4, this),
                new Interceptor(4,4, this),
                new Interceptor(4,4, this)
            };
        }
        public override string ToString()
        {
            string cruiser = $"Cruiser ({CurrentHealth}) ";
            AllAliveUnits.ForEach(unit => cruiser += unit + " ");
            return cruiser;
        }

        
        internal override void AttackEnemy(List<Cruiser> enemyCruisers)
        {
            var enemycruiser = enemyCruisers.OrderBy(unit => RandomService.Get()).FirstOrDefault();
            enemycruiser.RemoveHealth(this.RandomDamage);
            Console.Write($"Cruiser ({this.CurrentHealth}) attacked {enemycruiser.Army.Name} Cruiser ({enemycruiser.CurrentHealth}) \n");
        }

        internal override void AttackEnemy(Army enemyarmy)
        {
            var legion = enemyarmy.AllAliveCruisers.SelectMany(cruiser => cruiser.AllAliveUnits).ToList();
            var enemysquad = legion.OrderByDescending(unit => unit.CurrentHealth / unit.MaxHealth * 100).ThenBy(unit => RandomService.Get()).Take(5).ToList();
            if (enemysquad.Count != 0)
            {
                enemysquad.ForEach
                    (enemy =>
                    {
                        enemy.RemoveHealth(this.CanonDamage);
                        Console.Write($"Cruiser ({this.CurrentHealth}) attacked  {enemyarmy.Name} {enemy} \n");
                    });
            }
            else
            {
                AttackEnemy(enemyarmy.AllAliveCruisers);
            }
        }
    }
}
