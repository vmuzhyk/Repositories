using Exams_10_Chaos_League.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams_10_Chaos_League.Models
{
    public class Army
    {
        public List<Cruiser> Cruisers { get; set; }

        public string Name { get; set; }
        public bool IsTeamMakeTurn { get; set; }

        public Army(string name)
        {
            Name = name;
            Cruisers = new List<Cruiser>
            {
               new Cruiser(100),
               new Cruiser(100)
            };
        }

        public override string ToString()
        {
            var army = $"{Name} Army \n";
            foreach (var cruiser in Cruisers)
            {
                army += $"{cruiser} \n";
            }
            return army;
        }

    }
}
