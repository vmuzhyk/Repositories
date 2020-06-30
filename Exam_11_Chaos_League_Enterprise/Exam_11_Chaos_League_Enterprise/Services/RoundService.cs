using Exam_11_Chaos_League_Enterprise.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam_11_Chaos_League_Enterprise.Services
{
    public class RoundService
    {
        private List<Army> Armies { get; set; }
        private List<Army> AliveArmies => Armies.Where(army => army.AllAliveCruisers.Count > 0).ToList();
        private List<Army> ArmiesMadeturn => AliveArmies.Where(army => !army.IsMadeTurn).ToList();
        private List<Army> AvailableArmies => AliveArmies.Where(army => !army.IsChosen).ToList();


        public RoundService()
        {
            Armies = new List<Army>()
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

        public void Begin()
        {
            PrintFightField();
            while (AliveArmies.Count > 1)
            {
                AttackArmyStepByStep();
            }
            DisplayWinner();
        }

        private void DisplayWinner()
        {
            
        }

        private void AttackArmyStepByStep()
        {
            
        }

        private void PrintFightField()
        {
            Armies.ForEach(army => Console.WriteLine(army));
        }
    }
}
