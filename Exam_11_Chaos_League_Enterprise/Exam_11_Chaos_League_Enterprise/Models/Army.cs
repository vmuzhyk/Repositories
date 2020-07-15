using Exam_11_Chaos_League_Enterprise.Models.Abstract;
using Exam_11_Chaos_League_Enterprise.Services;
using System.Collections.Generic;
using System.Linq;

namespace Exam_11_Chaos_League_Enterprise.Models
{
    public class Army
    {
        public string Name { get; }
        public bool IsMadeTurn { get; set; }
        public bool IsChosen { get; set; }
        public List<Cruiser> Cruisers { get; set; }
        public List<Cruiser> AllAliveCruisers => Cruisers.Where(x => x.IsAlive).ToList();


        public Army(string name)
        {
            Name = name;
            Cruisers = new List<Cruiser>()
            {
                new Cruiser(100, 2, this, 2),
                new Cruiser(100, 2, this, 2)
            };
        }

        public override string ToString()
        {
            string army = $"{Name} army\n";
            AllAliveCruisers.ForEach(cruiser => army += cruiser + "\n");
            return army;
        }

        public List<Unit> GetSquad(int count)
        {
            var legion = AllAliveCruisers.SelectMany(cruiser => cruiser.AllAliveUnits).ToList();
            var squad = AllAliveCruisers.Concat(legion.Cast<Unit>()).OrderBy(unit => RandomService.Get()).Take(count).ToList();
            return squad;
        }
    }
}
