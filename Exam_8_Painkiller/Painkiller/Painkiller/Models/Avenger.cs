using Painkiller.Models;
using Painkiller.Models.Abstract;
using System;

namespace Painkiller.Services
{
    public class Avenger : Unit
    {
        public Avenger(int maxHealth, int damage, string name, Team team) : base(maxHealth, damage, name, team)
        {
            IsStunned = false;
            WasStunned = false;
        }

        public override void ReceiveInfluence(IUnit attacker)
        {
            if (WasStunned)
            {
                WasStunned = false;
                return;
            }

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
                WasStunned = true;
                Console.WriteLine($" {this.GetInfoExtended()} miss attack turn");
            }
        }
    }

}