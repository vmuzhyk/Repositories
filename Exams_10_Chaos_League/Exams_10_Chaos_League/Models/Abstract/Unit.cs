namespace Exams_10_Chaos_League.Models.Abstract
{
    public abstract class Unit
    {
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }

        public Unit(int maxHealth)
        {
            MaxHealth = maxHealth;
            CurrentHealth = maxHealth;
        }
        public void RemoveHealth(int damage)
        {
            CurrentHealth -= damage;
            //Thread.Sleep(200);
        }
    }
}
