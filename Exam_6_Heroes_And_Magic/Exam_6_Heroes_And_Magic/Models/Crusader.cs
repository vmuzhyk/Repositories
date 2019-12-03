using Exam_6_Heroes_And_Magic.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic.Models
{
    class Crusader : IUnit, IMortable, IAttack
    {
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int Damage { get; set; }
        public bool IsAlive { get => CurrentHealth > 0;}

        public Crusader (int maxHealth, int damage)
        {
            MaxHealth = maxHealth;
            Damage = damage;
        }

        public void RemoveHealth (int damage)
        {
            if (!IsAlive)
                return;

            CurrentHealth -= damage;
        }

}
}
