using Painkiller.Models;
using Painkiller.Models.Abstract;
using System;

namespace Painkiller.Services
{
    public class Avenger : Unit
    {
        public bool IsStunned { get; set; }
        public Avenger(int maxHealth, int damage, string name, Team team) : base(maxHealth, damage, name, team)
        {
            IsStunned = false;
        }

        public override void ReceiveInfluence(IUnit attacker)
        {
            IsStunned = true;
            Console.WriteLine($" {this.GetInfoExtended()} stunned after attack from {attacker.GetInfoBasic()}");
        }


        public override void HitBack(IUnit attacker)
        {
            if (IsStunned)
                return;
                
            base.HitBack(attacker);
        }

        public override void Attack(IUnit defender)
        {
            if (!IsStunned)
            base.Attack(defender);
            else
            {
                IsStunned = false;
                Console.WriteLine($" {this.GetInfoExtended()} miss attack turn on {defender.GetInfoBasic()}");
            }
        }
    }

}