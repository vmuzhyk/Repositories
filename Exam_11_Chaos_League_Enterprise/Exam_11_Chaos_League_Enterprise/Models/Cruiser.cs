using Exam_11_Chaos_League_Enterprise.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_11_Chaos_League_Enterprise.Models
{
    public class Cruiser : Unit
    {
        public List<Aircraft> Fleet;
        public List<Aircraft> AllAliveUnits => Fleet.Where(unit => unit.IsAlive).ToList();
        public Cruiser(int maxHealt, int damage) : base(maxHealt, damage)
        {
            Fleet = new List<Aircraft>()
            {
                new Fighter(8,2),
                new Fighter(8,2),
                new Fighter(8,2),
                new Fighter(8,2),
                new Bomber(6,12),
                new Bomber(6,12),
                new Bomber(6,12),
                new Interceptor(4,4),
                new Interceptor(4,4),
                new Interceptor(4,4)
            };
        }
        public override string ToString()
        {
            var cruiser = $"Cruiser ({this.CurrentHealth}) ";
            AllAliveUnits.ForEach(unit => cruiser += unit + " ");
            return cruiser;
        }
    }
}
