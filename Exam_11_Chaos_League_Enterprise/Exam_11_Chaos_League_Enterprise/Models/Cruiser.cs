using Exam_11_Chaos_League_Enterprise.Models.Abstract;
using System.Collections.Generic;
using System.Linq;

namespace Exam_11_Chaos_League_Enterprise.Models
{
    public class Cruiser : Unit
    {
        public List<Aircraft> Fleet;
        public Army Army { get; }
        public List<Aircraft> AllAliveUnits => Fleet.Where(unit => unit.IsAlive).ToList();
        public Cruiser(int maxHealt, int damage, Army army) : base(maxHealt, damage)
        {
            Army = army;
            Fleet = new List<Aircraft>()
            {
                new Fighter(8,2, this),
                new Fighter(8,2, this),
                new Fighter(8,2, this),
                new Fighter(8,2, this),
                new Bomber(6,12, this),
                new Bomber(6,12, this),
                new Bomber(6,12, this),
                new Interceptor(4,4, this),
                new Interceptor(4,4, this),
                new Interceptor(4,4, this)
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
