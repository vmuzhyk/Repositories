namespace Exams_10_Chaos_League.Models.Abstract
{
    public abstract class Aircraft : Unit
    {
        public int Damage { get; set; }
        public Cruiser ParentCruiser { get; }
        public Aircraft(int maxHealth, int damage, Cruiser parentCruiser) : base(maxHealth)
        {
            ParentCruiser = parentCruiser;
            Damage = damage;

        }
    }
}
