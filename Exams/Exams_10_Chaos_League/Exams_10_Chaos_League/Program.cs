using Exams_10_Chaos_League.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams_10_Chaos_League
{
    class Program
    {
        static void Main(string[] args)
        {
            new GameService().Begin();
            Console.ReadKey();
        }
    }
}
