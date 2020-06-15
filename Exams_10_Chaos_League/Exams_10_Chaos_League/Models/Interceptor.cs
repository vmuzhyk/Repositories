using Exams_10_Chaos_League.Models.Abstract;

namespace Exams_10_Chaos_League.Models
{
    public class Interceptor : Aircraft
    {
        public Interceptor(int maxHealth, int damage, Cruiser parent) : base(maxHealth, damage, parent)
        {
        }
        public override string ToString()
        {
            return $"I({CurrentHealth}) ";
        }
    }
}
