using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_7_Save_In_JSON
{
    public class Interface
    {
        public bool IsOver { get; set; }
        public bool IsCommandExecuted { get; set; }
        public Calculation Calculation { get; set; }

        private const string CommandExit = "EXIT";
        private const string CommandReset = "RESET";
        private const string CommandHelp = "HELP";
        private const string CommandLoad = "LOAD";
        private const string CommandSave = "SAVE";
        private const string CommandDisplay = "DISPLAY";
        private const string CommandYes = "YES";
        private const string CommandNo = "NO";
        private const string src = @"Saves.txt";

        public Interface()
        {
            Calculation = new Calculation();
            DisplayWelcomeMessage();
        }
        private void DisplayWelcomeMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to sum example");
            PrintAvailableCommands();
            Console.WriteLine();
        }
        public void Begin()
        {
            CheckFile();
            ValidateNewCalculation();
            SaveDialog();
        }

        private void ValidateNewCalculation()
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

                Calculation.Begin(input);
            }
        }
        private string ProcessInput()
        {
            Console.WriteLine();
            Console.Write("Enter a command, or number between 0 and 100: ");
            var input = Console.ReadLine();
            ExecuteCommand(input);
            return input;
        }

        private void ResetProgress()
        {
            Calculation.Sum = 0;
            Calculation.Step = 0;
        }

        private void ResetProgressWithMessage()
        {
            ResetProgress();
            Console.WriteLine("Progress is cleared");
        }

        private void CheckFile()
        {
            ValidateSaves();
            string[] lines = System.IO.File.ReadAllLines(src);
            if (IsAnyScoreSaved(lines))
            {
                StartGame();
            }
        }

        private bool IsAnyScoreSaved(string[] lines)
        {
            foreach (string item in lines)
            {
                var member = Int32.Parse(item);
                if (member != 0)
                {
                    return true;
                }
            }
            return false;
        }

        private void StartGame()
        {
            while (true)
            {
                Console.WriteLine("Press \"reset\", if you want to start new game or press \"load\" if you want to continue privious game!");
                switch (Console.ReadLine().ToUpper())
                {
                    case CommandReset:
                        ResetProgressWithMessage();
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
            string[] lines = { Calculation.Sum.ToString(), Calculation.Step.ToString()};
            File.WriteAllLines(src, lines);
        }
        private void SaveScoreWithMessage()
        {
            SaveScore();
            Console.WriteLine("Score is saved");
        }

        private void ValidateSaves()
        {
            if (!File.Exists(src))
            {
                File.Create(src).Dispose();
            }
        }

        private void LoadScore()
        {
            string[] lines = System.IO.File.ReadAllLines(src);
            Calculation.Sum = Int32.Parse(lines[0]);
            Calculation.Step = Int32.Parse(lines[1]);
            Console.WriteLine("Score is loaded");
        }

        private void SaveDialog()
        {
            while (true)
            {
                Console.WriteLine("Do you want to save the game? [Yes/No]:");
                switch (Console.ReadLine().ToUpper())
                {
                    case CommandYes:
                        SaveScoreWithMessage();
                        return;
                    case CommandNo:
                        ResetProgress();
                        SaveScore();
                        return;
                    default:
                        continue;
                }
            }
        }

        private void ExecuteCommand(string command)
        {
            switch (command.ToUpper())
            {
                case CommandExit:
                    IsOver = true;
                    Console.WriteLine("The game is finished");
                    break;
                case CommandReset:
                    IsCommandExecuted = true;
                    ResetProgressWithMessage();
                    break;
                case CommandHelp:
                    IsCommandExecuted = true;
                    PrintAvailableCommands();
                    break;
                case CommandDisplay:
                    IsCommandExecuted = true;
                    Calculation.DisplayScore();
                    break;
                case CommandSave:
                    IsCommandExecuted = true;
                    SaveScoreWithMessage();
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
