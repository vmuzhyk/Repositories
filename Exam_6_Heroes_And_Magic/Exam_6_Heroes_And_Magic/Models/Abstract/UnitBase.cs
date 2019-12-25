﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Exam_6_Heroes_And_Magic.Extentions;

namespace Exam_6_Heroes_And_Magic.Models.Abstract
{
    public abstract class UnitBase : IUnit, IMortable, IAttack
    {
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }

        public bool IsAlive  => CurrentHealth > 0; 

        public int Damage { get; set; }

        public string Name { get; }

        public string TeamName { get; }

        public UnitBase (int maxHealth, int damage, string name, string teamName)
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
            Thread.Sleep(200);
        }


        public void RemoveHealth(UnitBase attacker)
        {
            RemoveHealth(attacker.Damage);
            Console.WriteLine($" {GetInfoExtended()} after attack from {attacker.GetInfoBasic()}");
            if (!IsAlive)
                return;

            HitBack(attacker);
        }

        public virtual void Attack(UnitBase defender)
        {
            defender.RemoveHealth(this);
        }

        public void HitBack(UnitBase attacker)
        {
            attacker.ReceiveHitBack(this);
        }

        public virtual void ReceiveHitBack(UnitBase defender)
        {
            RemoveHealth(defender.Damage);
            Console.WriteLine($" {GetInfoExtended()} after hit back from {defender.GetInfoBasic()}");
        }

        public string GetInfoExtended()
        {
            return $"{this.TeamName}: {this.GetType().Name} {this.Name} ({this.CurrentHealth})";
        }

        public string GetInfoBasic()
        {
            return $"{this.GetType().Name} {this.Name}";
        }

        public virtual void Attack(Army defenderArmy)
        {
            this.Attack(defenderArmy.GetRandomAliveUnit());
        }

        public virtual void ActEachTurn()
        {  
        }
    }
}
