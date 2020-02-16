using Exam_9_Packman.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_9_Packman.Models
{
    public class Cherry : IItems
    {
        public int Coast { get; set; }
        public Cherry (int coast) 
        {
            Coast = coast;
        }
        public void InteractionWithPlayer(Player player)
        {
            player.CherryCount += Coast;
            Console.WriteLine($"Player get Cherry. Now Player's cherrycount is {player.CherryCount}");
        }
        public void CalcProbabilityToInteract(Player player)
        {
        }
    }
}
