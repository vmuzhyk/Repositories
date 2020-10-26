using Newtonsoft.Json;
using Painkiller.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Painkiller.Models
{
    public class Team
    {
        public string Name { get; }

        public List<Unit> AllUnits { get; set; }
        [JsonIgnore]
        public List<Unit> AliveUnits { get => AllUnits.Where(unit => unit.IsAlive).ToList(); }
        [JsonIgnore]
        public bool IsAllUnitsAlive { get => AliveUnits.Count > 0; }
        public Team(string name)
        {
            Name = name;
        }
                
        public void PrintAliveUnits()
        {
            Console.WriteLine($" Team Name: {Name}. Alive Units: { AliveUnits.Count}");
            AliveUnits.ForEach(unit => Console.WriteLine($" {unit.GetInfoBasic()}, current health {unit.CurrentHealth}"));
        }
        public IUnit GetRandomAliveUnit()
        {
            Random random = new Random();
            var randomUnit = random.Next(this.AliveUnits.Count);
            //Console.WriteLine(" " + random);
            return this.AliveUnits[randomUnit];
        }
        public void DisplayWinMessage()
        {
            Console.WriteLine($" Team Name: {Name} win.");
        }
        public void AssignTeam()
        {
            foreach (Unit unit in AllUnits)
            {
                unit.Team = this;
            }
        }
    }
}
