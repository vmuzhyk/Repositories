using Exams_10_Chaos_League.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams_10_Chaos_League.Models
{
    public class Cruiser : Unit
    {
        public List<Aircraft> Fleet { get; set; }
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
            foreach (var aircraft in Fleet)
            {
                cruiser += aircraft;
            }
            return cruiser;
        }

        
    }
}
