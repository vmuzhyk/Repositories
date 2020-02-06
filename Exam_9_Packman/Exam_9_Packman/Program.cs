using Exam_9_Packman.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_9_Packman
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
