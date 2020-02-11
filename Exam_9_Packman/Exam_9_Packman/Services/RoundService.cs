using Exam_9_Packman.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_9_Packman.Services
{
    class RoundService
    {
        public Player Player { get; set; }

        public RoundService()
        {
             Player = new Player(3, 3, 0, 0);
        }

        public void Begin()
        {
            Player.Name = SetPlayersName();
            Console.WriteLine($"Hi {Player.Name}!");
        }

        public string SetPlayersName()
        {
            Console.WriteLine();
            Console.Write("Enter your name: ");
            var input = Console.ReadLine();
            return input;
        }
    }
}
