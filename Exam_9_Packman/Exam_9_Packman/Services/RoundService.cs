using Exam_9_Packman.Extentions;
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
        
        private const string CommandUp = "w";
        private const string CommandLeft = "a";
        private const string CommandRight = "d";
        private const string CommandDown = "s";

        public RoundService()
        {
             Player = new Player(3, 3, 0, 0);
        }

        public void Begin()
        {
            Player.Name = SetPlayersName();
            Console.WriteLine($"Hi {Player.Name}!");
            PrintAvailableMovements();
            DisplayMoveDialog();
        }

        public string SetPlayersName()
        {
            Console.WriteLine();
            Console.Write("Enter your name: ");
            var input = Console.ReadLine();
            return input;
        }

        public void DisplayMoveDialog()
        {
            while (true)
            {
                Console.WriteLine($"Enter number of one of available movements please ");
                var input = Console.ReadLine();
                switch (input)
                {
                    case CommandUp:
                        Console.WriteLine("You move left");
                        break;
                    case CommandLeft:
                        Console.WriteLine("You move down");
                        break;
                    case CommandRight:
                        Console.WriteLine("You move right");
                        break;
                    case CommandDown:
                        Console.WriteLine("You move up");
                        break;
                    default:
                        Console.WriteLine("You enter not valid number or not a number at all");
                        break;
                }
                if (Player.CurrentHealth == 0)
                    return;
            }

        }

        public void AppearanceEachTurn()
        {
            var percent = RandomExtention.GenerateChance();
            if (percent <= 12)
                return;

            if ((percent > 12) && (percent <= 24))
                return;

            if ((percent > 24) && (percent <= 50))
                return;

            if ((percent > 50) && (percent <= 100))
                return;

            /*Damage *= CriticalDamage;
            IsAttackImproved = true;
            Console.WriteLine($" {GetInfoExtended()} improved his attack to {Damage}");*/
        }
        
        public void PrintAvailableMovements()
        {
            Console.WriteLine("Available movements:");
            Console.WriteLine($"{CommandUp} - move up");
            Console.WriteLine($"{CommandLeft} - move left");
            Console.WriteLine($"{CommandRight} - move right");
            Console.WriteLine($"{CommandDown} - move down");
            
        }
    }
}
