using Exams_10_Chaos_League.Models.Abstract;

namespace Exams_10_Chaos_League.Models
{
    public class Fighter : Aircraft
    {
        public Fighter(int maxHealth, int damage) : base(maxHealth, damage)
        {
        }

        public override string ToString()
        {
            return $"F({CurrentHealth}) ";
        }
    }
}
