using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic.Models.Abstract
{
    public abstract class MeeleUnit : IUnit, IMortable, IAttack
    {
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }

        public bool IsAlive  => CurrentHealth > 0; 

        public int Damage { get; set; }

        public string Name { get; }

        public MeeleUnit (int maxHealth, int damage, string name)
        {
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
            Damage = damage;
            Name = name;

        }

        public void RemoveHealth(int damage)
        {
            CurrentHealth -= damage;
        }
    }
}
