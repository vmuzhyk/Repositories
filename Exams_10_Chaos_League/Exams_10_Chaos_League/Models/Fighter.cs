using Exams_10_Chaos_League.Models.Abstract;

namespace Exams_10_Chaos_League.Models
{
    public class Fighter : Aircraft
    {
        public Fighter(int maxHealth, int damage, Cruiser parent) : base(maxHealth, damage, parent)
        {
        }

        public override string ToString()
        {
            return $"F({CurrentHealth}) ";
        }
    }
}
