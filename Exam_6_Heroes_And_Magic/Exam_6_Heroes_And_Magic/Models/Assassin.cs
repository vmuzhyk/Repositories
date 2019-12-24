using Exam_6_Heroes_And_Magic.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic.Models
{
    public class Assassin : MeleeUnitBase
    {
        public Assassin(int maxHealth, int damage, string name, string teamName) : base(maxHealth, damage, name, teamName)
        {
        }

        public override void ActEachTurn()
        {
            Random random = new Random();
            var percent = random.Next(1, 101);
            if (percent <= 20)
            {
                Console.WriteLine($" {GetInfoExtended()} improved his attack");
            }
        }
    }
}
