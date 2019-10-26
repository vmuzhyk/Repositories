using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_4_Chu_Va_Chi
{
    public class Game
    {
        private Player Human { get; set; }
        private Player Machine { get; set; }
        private Round Round { get; set; }

        public bool IsOver { get; set; }
        public bool IsCommandExecuted { get; set; }

        private const string CommandExit = "EXIT";
        private const string CommandReset = "RESET";
        private const string CommandHelp = "HELP";

        public Game()
        {
            DisplayWelcomeMessage();
            ResetProgress();
        }

        public void Begin()
        {
            while (true)
            {
                var input = ProcessInput();

                if (IsOver)
                    return;

                if (IsCommandExecuted)
                {
                    IsCommandExecuted = false;
                    continue;
                }

                Round.Begin(input);
            }
        }

        private string ProcessInput()
        {
            Console.WriteLine();
            Console.Write("Enter a command, or number between 0 and 2: ");
            var input = Console.ReadLine();
            ExecuteCommand(input);
            return input;
        }

        private void ResetProgress()
        {
            Human = new Player(0, 0, 0);
            Machine = new Player(0, 0, 0);
            Round = new Round(Human, Machine);
        }

        private void DisplayWelcomeMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to our Chu Va Chi game");
            PrintAvailableCommands();
            Console.WriteLine();
        }

        public void ExecuteCommand(string command)
        {
            switch (command.ToUpper())
            {
                case CommandExit:
                    IsOver = true;
                    string[] lines = { "First matyuk", "Second matyuk", "Third matyuk" };
                    System.IO.File.WriteAllLines(@"D:\Downloads\WriteMatyuk.txt", lines);
                    Console.WriteLine("The game is finished");
                    break;
                case CommandReset:
                    IsCommandExecuted = true;
                    Console.WriteLine("Progress is cleared");
                    ResetProgress();
                    break;
                case CommandHelp:
                    IsCommandExecuted = true;
                    PrintAvailableCommands();
                    break;
            }
        }

        public void PrintAvailableCommands()
        {
            Console.WriteLine("Available commands:");
            Console.WriteLine($"    {CommandExit.ToLower()} - finish the game");
            Console.WriteLine($"    {CommandReset.ToLower()} - reset the progress");
            Console.WriteLine($"    {CommandHelp.ToLower()} - display abailable commands");
        }
    }
}
