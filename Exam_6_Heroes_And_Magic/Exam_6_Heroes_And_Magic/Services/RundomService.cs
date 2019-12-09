using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic.Services
{
    public class RundomService
    {
        public int Get (int maxCount)
        {
            var rundom = new Random();
            var item = rundom.Next(maxCount);
            return item;
        }
    }
}
