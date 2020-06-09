using System.Collections.Generic;


namespace Exams_10_Chaos_League.Models
{
    public class Army
    {
        public List<Cruiser> Cruisers { get; set; }

        public string Name { get; set; }
        public bool IsMadeTurn { get; set; }

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
            Cruisers.ForEach(cruiser => army += $"{cruiser} \n");
            return army;
        }
    }
}
