using Exams_10_Chaos_League.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams_10_Chaos_League.Models
{
    public class Bomber : Aircraft
    {
        public Bomber(int maxHealth, int damage) : base(maxHealth, damage)
        {
        }
    }
}
