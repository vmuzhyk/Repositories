using Exams_10_Chaos_League.Models.Abstract;

namespace Exams_10_Chaos_League.Models
{
    public class Bomber : Aircraft
    {
        public Bomber(int maxHealth, int damage, Cruiser parent) : base(maxHealth, damage, parent)
        {
        }

        public override string ToString()
        {
            return $"B({CurrentHealth}) ";
        }
    }
}
