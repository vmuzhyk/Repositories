using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_11_Chaos_League_Enterprise.Services
{
    public static class RandomService
    {
        public static Random random;
        static RandomService()
        {
            random = new Random();
        }

        public static int Get()
        {
            int index = random.Next(0, 101);
            return index;
        }
    }
}
