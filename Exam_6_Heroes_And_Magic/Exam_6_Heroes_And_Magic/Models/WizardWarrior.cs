using Exam_6_Heroes_And_Magic.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic.Models
{
    public class WizardWarrior : WizardBase
    {
        private int FireballDamage { get; }
        public WizardWarrior(int maxHealth, int damage, string name, Army team, int maxMana, int improveMana, int fireballDamage) : base(maxHealth, damage, name, team, maxMana, improveMana)
        {
            FireballDamage = fireballDamage;
        }

        public void SpellFireball(UnitBase defender)
        {
            defender.RemoveHealth(FireballDamage);
            CurrentMana = 0;
            Console.WriteLine($" {defender.GetInfoExtended()} after fireball from {this.GetInfoBasic()}");
        }
        public override void Attack(UnitBase defender)
        {
            if (IsManaFull)
                SpellFireball(defender);
            else
                base.Attack(defender);
        }
    }
}
