using Exams_10_Chaos_League.Models.Abstract;
using Exams_10_Chaos_League.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exams_10_Chaos_League.Models
{
    public class Cruiser : Unit
    {
        public List<Aircraft> Fleet { get; }
        public Army Army { get; }
        public int DamageAgainsAircraft { get; }

        public int DamageAgainsCruiserMin { get; }
        public int DamageAgainsCruiserMax { get; }
        public List<Aircraft> AllAliveAircraft { get => Fleet.Where(fleet => fleet.IsAlive).ToList(); }
        public bool IsAllAircraftAlive { get => AllAliveAircraft.Count > 0; }
        public Cruiser(int maxHealth, int damage, Army army, int minDamage, int maxDamage) : base(maxHealth)
        {
            Army = army;
            DamageAgainsAircraft = damage;
            DamageAgainsCruiserMin = minDamage;
            DamageAgainsCruiserMax = maxDamage;
            Fleet = new List<Aircraft>
            {
                new Fighter(8, 2, this),
                new Fighter(8, 2, this),
                new Fighter(8, 2, this),
                new Fighter(8, 2, this),
                new Bomber(6, 12, this),
                new Bomber(6, 12, this),
                new Bomber(6, 12, this),
                new Interceptor(4, 4, this),
                new Interceptor(4, 4, this),
                new Interceptor(4, 4, this)
            };
        }
        public override string ToString()
        {
            var cruiser = $"Cruiser({CurrentHealth})\t";
            AllAliveAircraft.ForEach(aircraft => cruiser += aircraft);
            return cruiser;
        }

        public override void AttackEnemy(List<Cruiser> enemyCruisers)
        {
            var DamageAgainsCruiser = RandomService.Get(20, 36);
            var enemycruiser = enemyCruisers.OrderBy(x => x.CurrentHealth).First();
            enemycruiser.RemoveHealth(DamageAgainsCruiser);
            Console.WriteLine($"Cruiser({this.CurrentHealth})  attacked {enemycruiser.Army.Name} Cruiser ({enemycruiser.CurrentHealth})");
        }

        public override void AttackEnemy(Army enemyArmy)
        {
            var enemyUnits = enemyArmy.AllAliveCruisers
                .SelectMany(cruiser => cruiser.AllAliveAircraft)
                .OrderBy(x => x.CurrentHealth / x.MaxHealth * 100)
                .ThenBy(x => RandomService.Get())
                .Take(5).ToList();

            if (enemyUnits.Count > 0)
            {
                enemyUnits.ForEach(x =>
                {
                    x.RemoveHealth(this.DamageAgainsAircraft);
                    Console.WriteLine($"Cruiser({this.CurrentHealth})  attacked {x.ParentCruiser.Army.Name} {x}");
                });
            }
            else
            {
                AttackEnemy(enemyArmy.AllAliveCruisers);
            }
        }

    }
}
