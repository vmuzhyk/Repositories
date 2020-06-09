using Exams_10_Chaos_League.Models.Abstract;

namespace Exams_10_Chaos_League.Models
{
    public class Bomber : Aircraft
    {
        public Bomber(int maxHealth, int damage) : base(maxHealth, damage)
        {
        }

        public override string ToString()
        {
            return $"B({CurrentHealth}) ";
        }
    }
}
