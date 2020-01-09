using Painkiller.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painkiller
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
