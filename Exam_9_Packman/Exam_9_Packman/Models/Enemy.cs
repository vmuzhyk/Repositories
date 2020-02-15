using Exam_9_Packman.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_9_Packman.Models
{
    public class Enemy : IItems
    {        
        public int Damage { get; set; }
        public Enemy (int damage)
        {
            Damage = damage;
        }

        public void InteractionWithPlayer(Player player)
        {
            player.CurrentHealth -= Damage;
        }
    }

}
