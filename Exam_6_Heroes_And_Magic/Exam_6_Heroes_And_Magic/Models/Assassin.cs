using Exam_6_Heroes_And_Magic.Models.Abstract;
using Exam_6_Heroes_And_Magic.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic.Models
{
    public class Assassin : MeleeUnitBase
    {
        private bool IsAttackImproved { get; set; }
        private int CriticalDamage { get; }
        private int CriticalChance { get; }
        public Assassin(int maxHealth, int damage, string name, string teamName) : base(maxHealth, damage, name, teamName)
        {
            CriticalDamage = 2;
            CriticalChance = 20;

        }

        public override void Attack(MeleeUnitBase defender)
        {
            base.Attack(defender);
            if (!IsAttackImproved)
                return;

            Damage /= CriticalDamage;
            IsAttackImproved = false;
        }

        public override void ActEachTurn()
        {
            var percent = RandomExtention.GenerateChance();
            if (percent > CriticalChance)
                return;

            if (IsAttackImproved)
                return;

            Damage *= CriticalDamage;
            IsAttackImproved = true;
            Console.WriteLine($" {GetInfoExtended()} improved his attack to {Damage}");
        }
    }
}
