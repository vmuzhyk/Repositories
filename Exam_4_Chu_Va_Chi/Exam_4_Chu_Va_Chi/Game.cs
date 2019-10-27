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
        private const string CommandLoad = "LOAD";
        private const string CommandSave = "SAVE";
        private const string CommandDisplay = "DISPLAY";
        private const string src = @"D:\Downloads\WriteMatyuk.txt";

        public Game()
        {
            Human = new Player();
            Machine = new Player();
            Round = new Round(Human, Machine);
            DisplayWelcomeMessage();
        }

        public void Begin()
        {
            StartGame();
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
            Human.WinsCount = 0;
            Machine.WinsCount = 0;
            Human.DrawCount = 0;
            Machine.DrawCount = 0;
            Console.WriteLine("Progress is cleared");
        }
        
        private void DisplayWelcomeMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to our Chu Va Chi game");
            PrintAvailableCommands();
            Console.WriteLine();
        }
         private void StartGame()
         {
            while (true)
            {
                Console.WriteLine("Press \"reset\", if you want to start new game or press \"load\" if you want to continue privious game!");
                switch (Console.ReadLine().ToUpper())
                {
                    case CommandReset:
                        ResetProgress();
                        return;
                    case CommandLoad:
                        LoadScore();
                        return;
                    default:
                        continue;
                }
            }
         }

        private void SaveScore()
        {
            string[] lines = { Human.WinsCount.ToString(), Machine.WinsCount.ToString(), Human.DrawCount.ToString() };
            System.IO.File.WriteAllLines(src, lines);
            Console.WriteLine("Score is saved");
        }
        private void LoadScore()
        {
            string[] lines = System.IO.File.ReadAllLines(src);
            Human.WinsCount = Int32.Parse(lines[0]);
            Machine.WinsCount = Int32.Parse(lines[1]);
            Human.DrawCount = Int32.Parse(lines[2]);
            Machine.DrawCount = Int32.Parse(lines[2]);
            Console.WriteLine("Score is loaded");
        }

        private void ExecuteCommand(string command)
        {
            switch (command.ToUpper())
            {
                case CommandExit:
                    IsOver = true;
                    SaveScore();
                    Console.WriteLine("The game is finished");
                    break;
                case CommandReset:
                    IsCommandExecuted = true;
                    ResetProgress();
                    break;
                case CommandHelp:
                    IsCommandExecuted = true;
                    PrintAvailableCommands();
                    break;
                case CommandDisplay:
                    IsCommandExecuted = true;
                    Round.DisplayScore();
                    break;
                case CommandSave:
                    IsCommandExecuted = true;
                    SaveScore();
                    break;
                case CommandLoad:
                    IsCommandExecuted = true;
                    LoadScore();
                    break;
            }
        }
        private void PrintAvailableCommands()
        {
            Console.WriteLine("Available commands:");
            Console.WriteLine($"{CommandExit.ToLower()} - finish the game");
            Console.WriteLine($"{CommandReset.ToLower()} - reset the progress");
            Console.WriteLine($"{CommandHelp.ToLower()} - display abailable commands");
            Console.WriteLine($"{CommandLoad.ToLower()} - load saved game");
            Console.WriteLine($"{CommandSave.ToLower()} - save game");
            Console.WriteLine($"{CommandDisplay.ToLower()} - display game score");
        }
    }
}
