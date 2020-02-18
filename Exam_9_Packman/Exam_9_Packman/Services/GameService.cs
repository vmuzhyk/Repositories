using Exam_9_Packman.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Exam_9_Packman.Services
{
    class GameService
    {
        private readonly RoundService _roundService;

        public GameService()
        {
            _roundService = new RoundService();
            DisplayWelcomeMessage();
        }

        public bool IsOver { get; set; }


        private const string CommandExit = "EXIT";
        private const string CommandHelp = "HELP";
        private const string CommandStart = "START";
        private const string CommandDisplay = "DISPLAY";
        private const string src = @"saves.json";


        private void DisplayWelcomeMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to Packman");
            PrintAvailableCommands();
            Console.WriteLine();
        }
        public void Begin()
        {
            CheckFile();
            ValidateNewGame();
        }

        private void ValidateNewGame()
        {
            while (true)
            {
                var input = ProcessInput();
                ExecuteCommand(input);
                if (IsOver)
                    return;
            }
        }
        private string ProcessInput()
        {
            Console.WriteLine();
            Console.Write("Enter one of available command: ");
            var input = Console.ReadLine();
            return input;
        }

        private void CheckFile()
        {
            ValidateSaves();
            LoadScore();
        }


        private void SaveScore(List<Player> players)
        {
            Save save = new Save(players);
            string json = JsonConvert.SerializeObject(save, Formatting.Indented);

            File.WriteAllText(src, json);
        }

        private void SaveScoreWithMessage()
        {
            SaveScore(_roundService.SortedScores);
            Console.WriteLine("Score is saved");
        }

        private void ValidateSaves()
        {
            if (!File.Exists(src))
            {
                File.Create(src).Dispose();
                SaveScore(new List<Player>());
            }
        }

        private void LoadScore()
        {
            var save = LoadJson();
            _roundService.Scores = save.Scores;
        }

        private Save LoadJson()
        {
            using (StreamReader r = new StreamReader(src))
            {
                string json = r.ReadToEnd();
                var save = JsonConvert.DeserializeObject<Save>(json);
                return save;
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
                case CommandHelp:
                    PrintAvailableCommands();
                    break;
                case CommandDisplay:
                    _roundService.DisplayScore();
                    break;
                case CommandStart:
                    Console.WriteLine("Your game was started!");
                    _roundService.Begin();
                    SaveScoreWithMessage();
                    break;
            }
        }

        private void PrintAvailableCommands()
        {
            Console.WriteLine("Available commands:");
            Console.WriteLine($"{CommandExit.ToLower()} - finish the game");
            Console.WriteLine($"{CommandHelp.ToLower()} - display abailable commands");
            Console.WriteLine($"{CommandStart.ToLower()} - start game");
            Console.WriteLine($"{CommandDisplay.ToLower()} - display game score");
        }
    }
}

