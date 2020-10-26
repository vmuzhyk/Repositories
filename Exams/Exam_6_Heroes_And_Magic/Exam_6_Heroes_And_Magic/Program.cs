using Exam_6_Heroes_And_Magic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic
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
