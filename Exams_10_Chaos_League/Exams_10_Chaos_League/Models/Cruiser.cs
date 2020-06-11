using Exams_10_Chaos_League.Models.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace Exams_10_Chaos_League.Models
{
    public class Cruiser : Unit
    {
        public List<Aircraft> Fleet { get; set; }
        public List<Aircraft> AllAliveAircraft { get => Fleet.Where(fleet => fleet.IsAlive).ToList(); }
        public bool IsAllAircraftAlive { get => AllAliveAircraft.Count > 0; }
        public Cruiser(int maxHealth) : base(maxHealth)
        {
            Fleet = new List<Aircraft>
            {
                new Fighter(8, 2),
                new Fighter(8, 2),
                new Fighter(8, 2),
                new Fighter(8, 2),
                new Bomber(6, 12),
                new Bomber(6, 12),
                new Bomber(6, 12),
                new Interceptor(4, 4),
                new Interceptor(4, 4),
                new Interceptor(4, 4)
            };
        }
        public override string ToString()
        {
            var cruiser = $"Cruiser({CurrentHealth})\t";
            Fleet.ForEach(aircraft => cruiser += aircraft);
            return cruiser;
        }

        
    }
}
