﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace Exams_10_Chaos_League.Models.Abstract
{
    public abstract class Unit
    {
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; }

        public bool IsAlive => CurrentHealth > 0;

        public Unit(int maxHealth)
        {
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
        }
        public void RemoveHealth(int damage)
        {
            CurrentHealth -= damage;
            //Thread.Sleep(200);
        }

        public virtual void AttackEnemy(Army enemyArmy)
        {

        }

        public virtual void AttackEnemy(List<Cruiser> enemyCruisers)
        {

        }
    }
}
