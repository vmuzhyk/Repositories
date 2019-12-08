using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic.Models.Abstract
{
    public abstract class MeleeUnitBase : IUnit, IMortable, IAttack
    {
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }

        public bool IsAlive  => CurrentHealth > 0; 

        public int Damage { get; set; }

        public string Name { get; }

        public MeleeUnitBase (int maxHealth, int damage, string name)
        {
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
            Damage = damage;
            Name = name;

        }

        public void RemoveHealth(int damage)
        {
            CurrentHealth -= damage;
            Thread.Sleep(800);
        }

        public void RemoveHealth(MeleeUnitBase attacker, string defenderTeamName, string attackerTeamName)
        {
            RemoveHealth(attacker.Damage);
            Console.WriteLine($" {defenderTeamName}: {this.GetType().Name} {this.Name} ({this.CurrentHealth}) after attack from {attacker.GetType().Name} {attacker.Name}");
            if (!IsAlive)
                return;

            attacker.RemoveHealth(this.Damage);
            Console.WriteLine($" {attackerTeamName}: {attacker.GetType().Name} {attacker.Name} ({attacker.CurrentHealth}) after hit back from {this.GetType().Name} {this.Name}");
        }
    }
}
