using Exams_10_Chaos_League.Models.Abstract;
using Exams_10_Chaos_League.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exams_10_Chaos_League.Models
{
    public class Army
    {
        public List<Cruiser> Cruisers { get; set; }

        public List<Cruiser> AllAliveCruisers { get => Cruisers.Where(cruiser => cruiser.IsAlive).ToList(); }
        public bool IsAllCruisersAlive { get => AllAliveCruisers.Count > 0; }

        public string Name { get; set; }
        public bool IsMadeTurn { get; set; }
        public bool IsChoosen { get; set; }


        public Army(string name)
        {
            Name = name;
            Cruisers = new List<Cruiser>
            {
               new Cruiser(100, this),
               new Cruiser(100, this)
            };
        }

        
        public override string ToString()
        {
            var army = $"{Name} Army \n";
            Cruisers.ForEach(cruiser => army += $"{cruiser} \n");
            return army;
        }

        public List<Aircraft> GetSquad(int count)
        {
            var result = Cruisers.SelectMany(cruiser => cruiser.Fleet)
            .OrderBy(x => RandomService.MakeRandom())
            .Take(count)
            .ToList();

            return result;
        }
    }
}
