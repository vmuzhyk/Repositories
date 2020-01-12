using System;
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
        void Attack(Team defenderArmy);
        void HitBack(IUnit attacker);

        bool IsAlive { get; }

        string GetInfoBasic();
    }   
}
