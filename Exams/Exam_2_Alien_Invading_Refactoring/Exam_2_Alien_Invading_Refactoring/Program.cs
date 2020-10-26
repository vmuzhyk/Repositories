using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2_Alien_Invading_Refactoring
{
    class Program
    {
        static void Main(string[] args)
        {
            War war = new War();
            war.Begin();
            Console.ReadKey();
        }
    }
}
