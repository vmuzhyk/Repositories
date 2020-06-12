using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams_10_Chaos_League.Services
{
    public static class RandomService
    {
        private static Random _random;

        static RandomService()
        {
            _random = new Random();
        }
        public static int MakeRandom()
        {
            return _random.Next();
        }

        public static int Get(int count)
        {
            return _random.Next(count);
        }
    }
}
