using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Painkiller.Models.Abstract
{
    public abstract class Unit : IUnit
    {
        public string Name { get; }

        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int Damage { get; set; }

        public bool IsAlive => CurrentHealth > 0; 

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
    }
}
