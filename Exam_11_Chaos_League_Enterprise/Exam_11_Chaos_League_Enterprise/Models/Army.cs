using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_11_Chaos_League_Enterprise.Models
{
    public class Army
    {
        public string Name { get; }
        public List<Cruiser> Cruisers { get; set; }
        public List<Cruiser> AllAliveCruisers => Cruisers.Where(x => x.IsAlive).ToList();
        
        public Army(string name)
        {
            Name = name;
            Cruisers = new List<Cruiser>()
            {
                new Cruiser(100, 2),
                new Cruiser(100, 2)
            };
        }

        public override string ToString()
        {
            return $"{this.Name} army\n" +
                $"{this.Cruisers.ForEach()}";
        }
    }
}
