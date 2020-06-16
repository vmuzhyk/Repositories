using Exams_10_Chaos_League.Models.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace Exams_10_Chaos_League.Models
{
    public class Cruiser : Unit
    {
        public List<Aircraft> Fleet { get; set; }
        public Army Army { get; }
        public List<Aircraft> AllAliveAircraft { get => Fleet.Where(fleet => fleet.IsAlive).ToList(); }
        public bool IsAllAircraftAlive { get => AllAliveAircraft.Count > 0; }
        public Cruiser(int maxHealth, Army army) : base(maxHealth)
        {
            Army = army;
            Fleet = new List<Aircraft>
            {
                new Fighter(8, 2, this),
                new Fighter(8, 2, this),
                new Fighter(8, 2, this),
                new Fighter(8, 2, this),
                new Bomber(6, 12, this),
                new Bomber(6, 12, this),
                new Bomber(6, 12, this),
                new Interceptor(4, 4, this),
                new Interceptor(4, 4, this),
                new Interceptor(4, 4, this)
            };
        }
        public override string ToString()
        {
            var cruiser = $"Cruiser({CurrentHealth})\t";
            AllAliveAircraft.ForEach(aircraft => cruiser += aircraft);
            return cruiser;
        }

        
    }
}
