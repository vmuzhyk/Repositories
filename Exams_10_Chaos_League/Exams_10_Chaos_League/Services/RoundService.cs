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
                new Army("Pretorians")
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
            var random = new Random().Next(AllFightArmies.Count);
            //Console.WriteLine(" " + random);
            return AllFightArmies[random];
        }
        private void AttackArmyByArmy()
        {
            var army = GetRandomArmy();
            //here must be method of chosen 5 items from army
            army.IsMadeTurn = true;
            Console.WriteLine(army.Name);
        }
    }
}
