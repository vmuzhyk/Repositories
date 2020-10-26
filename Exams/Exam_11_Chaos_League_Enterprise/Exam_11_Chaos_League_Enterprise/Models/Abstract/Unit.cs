﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_11_Chaos_League_Enterprise.Models.Abstract
{
    public abstract class Unit
    {
        public int MaxHealth { get; }
        public int CurrentHealth { get; set; }
        public int Damage { get; }
        public bool IsAlive => CurrentHealth > 0;

        public Unit(int maxHealt, int damage)
        {
            MaxHealth = maxHealt;
            CurrentHealth = maxHealt;
            Damage = damage;

        }

        public void RemoveHealth(int damage)
        {
            CurrentHealth -= damage;
        }

        internal abstract void AttackEnemy(Army enemyarmy);

        internal abstract void AttackEnemy(List<Cruiser> cruisers);
        
    }
}
