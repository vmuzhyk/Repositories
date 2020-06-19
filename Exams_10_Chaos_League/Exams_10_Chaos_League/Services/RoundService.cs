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
        private List<Army> AliveArmies { get => Armies.Where(army => army.IsAllCruisersAlive).ToList(); }
        private List<Army> AllFightArmies { get => AliveArmies.Where(army => !army.IsMadeTurn).ToList(); }
        private List<Army> AllAvailableArmyEnemies { get => AliveArmies.Where(army => !army.IsChoosen).ToList(); }

        public RoundService()
        {
            Armies = new List<Army>
            {
                new Army("Humans"),
                new Army("Necromants"),
                /*new Army("Pretorians"),
                new Army("Orcs"),
                new Army("Elfs"),
                new Army("Demons"),
                new Army("Barbarians"),
                new Army("Dwarfs")*/
            };

        }
        internal void Begin()
        {
            DisplayFightField();
            while (AliveArmies.Count > 1)
            {
                while (AllFightArmies.Count != 0)
                    AttackArmyByArmy();

                AliveArmies.ForEach(army => army.IsMadeTurn = false);
            }

            DisplayWinner();
        }

        private void DisplayWinner()
        {
            Console.WriteLine("Ку-ку!!!");
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


        public void AttackRandomEnemy(List<Aircraft> squad)
        {
            squad.ForEach(unit =>
            {
                Console.Write($"{unit} attaked ");
                if (unit is Bomber)
                {
                    var enemycruiser = AllAvailableArmyEnemies.SelectMany(army => army.AllAliveCruisers)
                    .OrderBy(x => RandomService.MakeRandom()).First();
                    if (enemycruiser != null)
                    {
                        enemycruiser.RemoveHealth(unit.Damage);
                        Console.WriteLine($"{enemycruiser.Army.Name} Cruiser ({enemycruiser.CurrentHealth})");
                    }
                    else return;
                }
                else
                {
                    var enemyArmy = GetRandomArmyEnemy();
                    if (enemyArmy != null)
                    {
                        var enemyUnit = enemyArmy.GetSquad(1).FirstOrDefault();
                        if (enemyUnit != null)
                        {
                            enemyUnit.RemoveHealth(unit.Damage);
                            Console.WriteLine($"{enemyUnit.ParentCruiser.Army.Name} {enemyUnit}");
                        }
                        else
                        {
                            var enemycruiser = enemyArmy.AllAliveCruisers.OrderBy(x => RandomService.MakeRandom()).First();
                            enemycruiser.RemoveHealth(unit.Damage);
                            Console.WriteLine($"{enemycruiser.Army.Name} {enemycruiser}");
                        }
                    }
                    else return;
                }
            });

        }
    }
}
