using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace Painkiller.Models.Abstract
{
    public class Unit : IUnit
    {
        public string Name { get; }
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int Damage { get; set; }
        public bool IsStunned { get; set; }
        public bool WasStunned { get; set; }
        public bool IsAlive => CurrentHealth > 0;
        [JsonIgnore]
        public Team Team { get; }
        public Unit(int maxHealth, int damage, string name, Team team)
        {
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
            Damage = damage;
            Name = name;
            Team = team;
        }

        public string GetInfoExtended()
        {
            return $"{this.Team.Name}: {this.GetType().Name} {this.Name} ({this.CurrentHealth})";
        }
        public string GetInfoBasic()
        {
            return $"{this.GetType().Name} {this.Name}";
        }

        public virtual void Attack(IUnit defender)
        {
            defender.RemoveHealth(this);
        }

        public void RemoveHealth(int damage)
        {
            CurrentHealth -= damage;
            //Thread.Sleep(200);
        }

        public void RemoveHealth(IUnit attacker)
        {
            RemoveHealth(attacker.Damage);
            Console.WriteLine($" {GetInfoExtended()} after attack from {attacker.GetInfoBasic()}");
            if (!IsAlive)
                return;

            HitBack(attacker);
        }
        public virtual void HitBack(IUnit attacker)
        {
            attacker.ReceiveHitBack(this);
        }

        public virtual void ReceiveHitBack(IUnit defender)
        {
            RemoveHealth(defender.Damage);
            Console.WriteLine($" {GetInfoExtended()} after hit back from {defender.GetInfoBasic()}");
        }

        public virtual void ReceiveInfluence(IUnit attacker)
        {
        }

        public virtual void MakeInfluence(IUnit defender)
        {
        }
    }
}
