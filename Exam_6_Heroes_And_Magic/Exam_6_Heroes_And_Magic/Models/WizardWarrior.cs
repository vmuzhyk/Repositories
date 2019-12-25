using Exam_6_Heroes_And_Magic.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic.Models
{
    public class WizardWarrior : UnitBase, IWizard
    {
        public int CurrentMana { get; set; }
        public int MaxMana { get; }
        public int ImproveMana { get; }
        public WizardWarrior(int maxHealth, int damage, int maxMana, int improveMana, string name, string teamName) : base(maxHealth, damage, name, teamName)
        {
            CurrentMana = maxMana;
            MaxMana = maxMana;
            ImproveMana = improveMana;
        }

        public override void ActEachTurn()
        {
            if (CurrentMana == MaxMana)
                return;

            int difference = MaxMana - CurrentMana;
            int incrementMana = difference < ImproveMana ? difference : ImproveMana;
                       
            CurrentMana = CurrentMana + incrementMana;
            Console.WriteLine($" {GetInfoExtended()} improved his mana to {CurrentMana}");
        }
    }
}
