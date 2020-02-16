using Exam_9_Packman.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_9_Packman.Models
{
    public class Banana : IItems
    {
        public int Coast { get; set; }
        public Banana(int coast)
        {
            Coast = coast;
        }

        public void InteractionWithPlayer(Player player)
        {
            player.Score += Coast;
            Console.WriteLine($"Player get Banana. Now Player's score is {player.Score}");
        }

        public void CalcProbabilityToInteract(Player player)
        {
        }
    }
}
