using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam_6_Heroes_And_Magic.Models.Abstract;

namespace Exam_6_Heroes_And_Magic.Models
{
    public class WizardHealer : WizardBase
    {
        public WizardHealer(int maxHealth, int damage, string name, Army team, int maxMana, int improveMana) : base(maxHealth, damage, name, team, maxMana, improveMana)
        {
        }
        public override void Attack(UnitBase defender)
        {
            if (!IsManaFull)
                return;

             Heal(Team.WeakUnit);
        }

        public override void HitBack(UnitBase attacker)
        {
        }

        private void Heal(UnitBase weakUnit)
        {
            weakUnit.CurrentHealth = weakUnit.MaxHealth;
            CurrentMana = 0;
            Console.WriteLine($" {weakUnit.GetInfoExtended()} after healing from {this.GetInfoBasic()}");
        }
    }
}