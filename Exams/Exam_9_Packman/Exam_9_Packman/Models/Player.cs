using Exam_9_Packman.Models.Abstract;
using Newtonsoft.Json;

namespace Exam_9_Packman.Models
{
    public class Player : IPlayer
    {
        public string Name { get; set; }
        [JsonIgnore]
        public int CurrentHealth { get; set; }
        [JsonIgnore]
        public int MaxHealth { get; set; }
        public int Score { get; set; }
        [JsonIgnore]
        public int CherryCount { get; set; }

        public Player(int maxHealth, int currentHealth, int score, int cherryCount)
        {
            MaxHealth = maxHealth;
            CurrentHealth = currentHealth;
            Score = score;
            CherryCount = cherryCount;
        }
    }
}
