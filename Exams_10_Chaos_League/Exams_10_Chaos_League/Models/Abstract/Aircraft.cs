namespace Exams_10_Chaos_League.Models.Abstract
{
    public abstract class Aircraft : Unit
    {
        public int Damage { get; set; }
        public Aircraft(int maxHealth, int damage) : base(maxHealth)
        {
            Damage = damage;
        }
    }
}
