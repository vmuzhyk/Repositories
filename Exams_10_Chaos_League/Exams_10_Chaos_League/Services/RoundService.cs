using Exams_10_Chaos_League.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exams_10_Chaos_League.Services
{
    public class RoundService
    {
        public List<Army> Armies { get; set; }
        public List<Army> AllFightArmies { get => Armies.Where(army => !army.IsMadeTurn).ToList();}
        

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

        public Army GetRandomArmy()
        {
            var random = RandomService.Get(AllFightArmies.Count);
            //Console.WriteLine(" " + random);
            return AllFightArmies[random];
        }
        private void AttackArmyByArmy()
        {
            var army = GetRandomArmy();
            army.IsMadeTurn = true;
            Console.Write($"{army.Name.PadRight(15)}");
            var squad = army.GetSquad(5);
            squad.ForEach(unit => Console.Write($" {unit}"));
            Console.WriteLine();

        }
    }
}
