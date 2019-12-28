using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic.Models.Abstract
{
    public abstract class WizardBase : UnitBase, IWizard
    {

        public int CurrentMana { get; set; }
        public int MaxMana { get; }
        public int ImproveMana { get; }
        public bool IsManaFull => CurrentMana == MaxMana;

        public WizardBase(int maxHealth, int damage, string name, Army team, int maxMana, int improveMana) : base(maxHealth, damage, name, team)
        {
            MaxMana = maxMana;
            CurrentMana = MaxMana;
            ImproveMana = improveMana;
            
        }
        public override void ActEachTurn()
        {
            if (IsManaFull)
                return;

            int difference = MaxMana - CurrentMana;
            int incrementMana = difference < ImproveMana ? difference : ImproveMana;

            CurrentMana = CurrentMana + incrementMana;
            //Console.WriteLine($" {GetInfoExtended()} improved his mana to {CurrentMana}");
        }
    }
}
