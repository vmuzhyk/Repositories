using Exam_11_Chaos_League_Enterprise.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_11_Chaos_League_Enterprise.Models
{
    public class Bomber : Aircraft
    {
        public Bomber(int maxHealt, int damage) : base(maxHealt, damage)
        {
        }

        public override string ToString()
        {
            return $"B({this.CurrentHealth})";
        }
    }
}
