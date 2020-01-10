using Painkiller.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painkiller.Models
{
    public class Team
    {
        public string Name { get; }
        public List<IUnit> AllUnits { get; set; }
        public List<IUnit> AliveUnits { get => AllUnits.Where(unit => unit.IsAlive).ToList(); }
        public bool IsAllUnitsAlive { get => AliveUnits.Count > 0; }
        public Team(string name)
        {
            Name = name;
        }
                
        public void PrintAliveUnits()
        {
            Console.WriteLine($" Team Name: {Name} win. Alive Units: { AliveUnits.Count}");
            AliveUnits.ForEach(unit => Console.WriteLine($" {unit.GetInfoBasic()}, current health {unit.CurrentHealth}"));
        }

    }
}
