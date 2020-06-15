using Exams_10_Chaos_League.Models;
using Exams_10_Chaos_League.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exams_10_Chaos_League.Services
{
    public class RoundService
    {
        public List<Army> Armies { get; set; }
        public List<Army> AllFightArmies { get => Armies.Where(army => !army.IsMadeTurn).ToList();}
        public List<Army> AllAvailableArmyEnemies { get => Armies.Where(army => !army.IsChoosen).ToList(); }

        public RoundService()
        {
            Armies = new List<Army>
            {
                new Army("Humans"),
                new Army("Necromants"),
                new Army("Pretorians"),
                new Army("Orcs"),
                new Army("Elfs"),
                new Army("Demons"),
                new Army("Barbarians"),
                new Army("Dwarfs")
            };

        }
        internal void Begin()
        {
            DisplayFightField();
            while (AllFightArmies.Count != 0)
                AttackArmyByArmy();


            DisplayWinner();
        }

        private void DisplayWinner()
        {
            
        }

        public void DisplayFightField()
        {
            Armies.ForEach(army => Console.WriteLine(army));
        }

        public Army GetRandomArmyEnemy()
        {
            var random = RandomService.Get(AllAvailableArmyEnemies.Count);
            return AllAvailableArmyEnemies[random];
        }

        public Army GetRandomArmy()
        {
            var random = RandomService.Get(AllFightArmies.Count);
            return AllFightArmies[random];
        }
        private void AttackArmyByArmy()
        {
            var army = GetRandomArmy();
            army.IsChoosen = true;
            var squad = army.GetSquad(5);
            army.IsMadeTurn = true;
            Console.WriteLine($"\n{army.Name}");
            AttackRandomEnemy(squad);
            army.IsChoosen = false;
        }

        /*public void PrintSquad(Army army, List<Aircraft> squad)
        {
            Console.Write($"{army.Name.PadRight(15)}");
            squad.ForEach(unit => Console.Write($" {unit}"));
            Console.WriteLine();
        }*/

        public Aircraft GetRandomEnemy()
        {
            var enemyArmy = GetRandomArmyEnemy();
            var enemyUnit = enemyArmy.GetSquad(1);
            return enemyUnit.First();
        }

        public void AttackRandomEnemy(List<Aircraft> squad)
        {
            squad.ForEach(unit => 
            {
                Console.Write($"{unit} attaked ");
                if (unit is Bomber) {
                    var enemyArmy = GetRandomArmyEnemy();
                    var enemycruiser = Armies.SelectMany(army => army.Cruisers)
                    .OrderBy(x => RandomService.MakeRandom()).First();
                    enemycruiser.RemoveHealth(unit.Damage);
                    Console.WriteLine($"{enemyArmy.Name} Cruiser ({enemycruiser.CurrentHealth})"); 
                }
                else
                {
                    var enemy = GetRandomEnemy();
                    enemy.RemoveHealth(unit.Damage);
                    Console.WriteLine($"{enemy.Parent.Army.Name} {enemy}");
                }
            });

        }
    }
}
