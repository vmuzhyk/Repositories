using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Painkiller.Models;
using Painkiller.Models.Abstract;

namespace Painkiller.Models
{
    public class Monk : Unit
    {
        public int AxDamage { get; set; }
        public int CriticalChance { get; }
        public bool IsAxThrown { get; set; }
        public Monk (int maxHealth, int damage, string name, Team team, int axDamage, int criticalChance) : base(maxHealth, damage, name, team)
        {
            AxDamage = axDamage;
            CriticalChance = criticalChance;
            IsAxThrown = false;
        }

        /*public override void Attack(IUnit defender)
        {
            if (IsAxThrown)
                return;

            var percent = new Random().Next(1, 101);
            if (percent > CriticalChance)
                return;
            

            
            IsAxThrown = true;
            Console.WriteLine($" {GetInfoExtended()} improved his attack to {Damage}");
            
            
        }*/

        
    }
}
