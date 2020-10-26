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
        bool IsStunned { get; set; }
        bool WasStunned { get; set; }

        void Attack(IUnit defender);
        void HitBack(IUnit attacker);
        void ReceiveHitBack(IUnit defender);
        void RemoveHealth(IUnit attacker);
        void RemoveHealth(int damage);

        bool IsAlive { get; }

        string GetInfoBasic();
        string GetInfoExtended();
        void ReceiveInfluence(IUnit attacker);

        void MakeInfluence(IUnit defender);
    }   
}
