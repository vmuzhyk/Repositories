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
        public string ChoosenDirection { get; set; }

        public RoundService()
        {
             Player = new Player(3, 3, 0, 0);
        }

        public void Begin()
        {
            Player.Name = SetPlayersName();
            Console.WriteLine($"Hi {Player.Name}!");
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
                Console.WriteLine($"Enter one of numbers 4, 5, 6 or 8, please ");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "4":
                        Console.WriteLine("You move left");
                        break;
                    case "5":
                        Console.WriteLine("You move down");
                        break;
                    case "6":
                        Console.WriteLine("You move right");
                        break;
                    case "8":
                        Console.WriteLine("You move up");
                        break;
                    default:
                        Console.WriteLine("You enter not valid number or not a number at all");
                        break;
                }
                if (Player.CurrentHealth == 0)
                    return;
            }

            /*private bool IsInputValid(bool isInteger, int number)
            {
                if (!isInteger)
                {
                    Console.WriteLine("Number should be an integer value");
                    return false;
                }

                if (number < 0 || number > TeamB.AliveUnits.Count - 1)
                {
                    Console.WriteLine($"Number should be between 0 and {TeamB.AliveUnits.Count - 1 }");
                    return false;
                }

                return true;
            }*/

        }
    }
}
