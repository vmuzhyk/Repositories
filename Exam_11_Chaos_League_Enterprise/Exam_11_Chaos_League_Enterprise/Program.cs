using Exam_11_Chaos_League_Enterprise.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_11_Chaos_League_Enterprise
{
    class Program
    {
        static void Main(string[] args)
        {
            new GameService().Start();
            Console.ReadKey();
        }
    }
}
