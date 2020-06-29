using Exam_11_Chaos_League_Enterprise.Models.Abstract;
using System.Collections.Generic;
using System.Linq;

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
            string cruiser = $"Cruiser ({CurrentHealth}) ";
            AllAliveUnits.ForEach(unit => cruiser += unit + " ");
            return cruiser;
        }
    }
}
