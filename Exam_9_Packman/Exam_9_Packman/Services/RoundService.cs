using Exam_9_Packman.Extentions;
using Exam_9_Packman.Models;
using Exam_9_Packman.Models.Abstract;
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
        
        public IItems ItemAppearedInCurrentTurn { get; set; }   //Item Appeared In Current Turn
        public string AppearanceDirectionInCurrentTurn { get; set; } //Appearance Direction In Current Turn


        private const string CommandUp = "w";
        private const string CommandLeft = "a";
        private const string CommandRight = "d";
        private const string CommandDown = "s";
        private const string DirectionUp = "above";
        private const string DirectionLeft = "on the left-hand side";
        private const string DirectionRight = "on the right-hand side";
        private const string DirectionDown = "below";

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
                        continue;
                }
                AppearanceEachTurn();
                if (ItemAppearedInCurrentTurn != null)
                    ItemAppearedInCurrentTurn.InteractionWithPlayer(Player);
                
                

                if ((Player.CurrentHealth == 0) || (Player.CherryCount == 5))
                    return;
            }
        }
                 
        public void AppearanceEachTurn()
        {
            ItemAppearedInCurrentTurn = AppearItem();
            AppearanceDirectionInCurrentTurn = AppearanceDirections();
            if (ItemAppearedInCurrentTurn != null)
                Console.WriteLine($"{ItemAppearedInCurrentTurn.GetType().Name} was appeared {AppearanceDirectionInCurrentTurn} from You!");
            else
                Console.WriteLine("Nothing was appeared!");
        }

        public IItems AppearItem()
        {
            var percent = RandomExtention.GenerateChance();
            if (percent <= 12)
                return new Enemy(1);

            if ((percent > 12) && (percent <= 24))
                return new Cherry(1);

            if ((percent > 24) && (percent <= 50))
                return new Banana(10);

            else 
                return null;
        }
        
        public string AppearanceDirections()
        {
            var percent = RandomExtention.GenerateChance();
            if (percent <= 25)
                return DirectionUp;

            if ((percent > 25) && (percent <= 50))
                return DirectionLeft;

            if ((percent > 50) && (percent <= 75))
                return DirectionRight;

            else
                return DirectionDown;
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
