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

        public string TeamName { get; }

        public MeleeUnitBase (int maxHealth, int damage, string name, string teamName)
        {
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
            Damage = damage;
            Name = name;
            TeamName = teamName;
        }

        public void RemoveHealth(int damage)
        {
            CurrentHealth -= damage;
            Thread.Sleep(800);
        }


        public void RemoveHealth(MeleeUnitBase attacker)
        {
            RemoveHealth(attacker.Damage);
            Console.WriteLine($" {this.TeamName}: {this.GetType().Name} {this.Name} ({this.CurrentHealth}) after attack from {attacker.GetType().Name} {attacker.Name}");
            if (!IsAlive)
                return;

            HitBack(attacker);
        }

        public virtual void Attack(MeleeUnitBase defender)
        {
            defender.RemoveHealth(this);
        }

        public void HitBack(MeleeUnitBase attacker)
        {
            attacker.ReceiveHitBack(this.Damage);
            Console.WriteLine($" {attacker.TeamName}: {attacker.GetType().Name} {attacker.Name} ({attacker.CurrentHealth}) after hit back from {this.GetType().Name} {this.Name}");
        }

        public virtual void ReceiveHitBack(int damage)
        {
            RemoveHealth(damage);
        }
    }
}
