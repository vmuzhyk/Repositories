namespace Exams_10_Chaos_League.Models.Abstract
{
    public abstract class Aircraft : Unit
    {
        public int Damage { get; set; }
        public Cruiser Parent { get; }
        public Aircraft(int maxHealth, int damage, Cruiser parent) : base(maxHealth)
        {
            Parent = parent;
            Damage = damage;

        }
    }
}
