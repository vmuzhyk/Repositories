using Exam_9_Packman.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_9_Packman.Models
{
    class Player : IPlayer
    {
        public string Name { get; set; }
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int Score { get; set; }
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
