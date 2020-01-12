﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painkiller.Models.Abstract
{
    public interface IUnit
    {
        string Name { get; }
        int CurrentHealth { get; set; }
        int MaxHealth { get; set; }
        int Damage { get; set; }

        Team Team { get; }

        void Attack(IUnit defender);
        void HitBack(IUnit attacker);
        void ReceiveHitBack(IUnit defender);
        void RemoveHealth(IUnit attacker);

        bool IsAlive { get; }

        string GetInfoBasic();
    }   
}