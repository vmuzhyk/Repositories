using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private const string CommandReset = "RESET";
        private const string CommandHelp = "HELP";
        private const string CommandStart = "START";
        private const string CommandLoad = "LOAD";
        private const string CommandSave = "SAVE";
        private const string CommandContinue = "CONTINUE";
        private const string CommandDisplay = "DISPLAY";
        private const string CommandYes = "YES";
        private const string CommandNo = "NO";
        private const string src = @"saves.json";


        private void DisplayWelcomeMessage()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to Painkiller");
            PrintAvailableCommands();
            Console.WriteLine();
        }
        public void Begin()
        {
            CheckFile();
            ValidateNewGame();
            SaveDialog();
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

        private void ResetProgress()
        {
            //_roundService.CreateTwoTeams();
        }

        private void ResetProgressWithMessage()
        {
            ResetProgress();
            Console.WriteLine("Progress is cleared");
        }

        private void CheckFile()
        {
            /*ValidateSaves();
            var save = LoadJson();

            if (IsAnyScoreSaved(save))
            {
                StartGame();
            }*/
        }

        /*private bool IsAnyScoreSaved(Save save)
        {
            return save.IsAnyChange;
        }*/

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
            /*Save save = new Save(_roundService.TeamA, _roundService.TeamB, _roundService.IsTeamATurn, _roundService.IsAnyChange);
            string json = JsonConvert.SerializeObject(save, Formatting.Indented);

            File.WriteAllText(src, json);*/
        }
        private void SaveScoreWithMessage()
        {
            SaveScore();
            Console.WriteLine("Score is saved");
        }

        private void ValidateSaves()
        {
           /* if (!File.Exists(src))
            {
                File.Create(src).Dispose();
            }*/
        }

        private void LoadScore()
        {
           /* var save = LoadJson();
            _roundService.Load(save.TeamA, save.TeamB, save.IsTeamATurn);*/
        }


        /*private Save LoadJson()
        {
            using (StreamReader r = new StreamReader(src))
            {
                string json = r.ReadToEnd();
                var save = JsonConvert.DeserializeObject<Save>(json);
                return save;
            }

        }*/

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
                    ResetProgressWithMessage();
                    break;
                case CommandHelp:
                    PrintAvailableCommands();
                    break;
                case CommandDisplay:
                    //_roundService.DisplayScore();
                    break;
                case CommandSave:
                    SaveScoreWithMessage();
                    break;
                case CommandLoad:
                    LoadScore();
                    break;
                case CommandStart:
                    Console.WriteLine("Your game was started!");
                    _roundService.Begin();
                    break;
                case CommandContinue:
                    Console.WriteLine("Your game was continued!");
                    //_roundService.Continue();
                    break;
            }
        }
        private void PrintAvailableCommands()
        {
            Console.WriteLine("Available commands:");
            Console.WriteLine($"{CommandExit.ToLower()} - finish the game");
            Console.WriteLine($"{CommandReset.ToLower()} - reset the progress");
            Console.WriteLine($"{CommandHelp.ToLower()} - display abailable commands");
            Console.WriteLine($"{CommandStart.ToLower()} - start game");
            Console.WriteLine($"{CommandLoad.ToLower()} - load saved game");
            Console.WriteLine($"{CommandContinue.ToLower()} - continue game");
            Console.WriteLine($"{CommandSave.ToLower()} - save game");
            Console.WriteLine($"{CommandDisplay.ToLower()} - display game score");
        }
    }
}

