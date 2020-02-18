using Exam_9_Packman.Models.Abstract;
using System;

namespace Exam_9_Packman.Models
{
    public class Enemy : IItems
    {
        public int Damage { get; set; }
        public int CriticalChance { get; set; }
        public Enemy(int damage, int criticalChance)
        {
            Damage = damage;
            CriticalChance = criticalChance;
        }

        public void InteractionWithPlayer(Player player)
        {
            player.CurrentHealth -= Damage;
            Console.WriteLine($"Player met the Enemy. Now Player's health is {player.CurrentHealth}");
        }

        public void CalcProbabilityToInteract(Player player)
        {
            var percent = new Random().Next(1, 101);
            if (percent <= CriticalChance)
                InteractionWithPlayer(player);
        }
    }

}
