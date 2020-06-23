using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_11_Chaos_League_Enterprise.Models.Abstract
{
    public class Aircraft : Unit
    {
        public Aircraft(int maxHealt, int damage) : base(maxHealt, damage)
        {
        }
    }
}
