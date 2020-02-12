using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_9_Packman.Extentions
{
    public static class RandomExtention
    {
        private static Random _random;
        static RandomExtention()
        {
            _random = new Random();
        }

        public static int GenerateChance()
        {
            return _random.Next(1, 101);
        }

    }
}
