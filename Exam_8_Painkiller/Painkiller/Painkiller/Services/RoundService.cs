using System;
using Painkiller.Models;
using Painkiller.Models.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painkiller.Services
{
    public class RoundService
    {
        private Team TeamA { get; set; }
        private Team TeamB { get; set; }
        private bool IsTeamATurn { get; set; }
        private int ChosenOpponent { get; set; }
        private bool IsCommandExecuted { get; set; }
        private bool IsExitDone { get; set; }

        private const string CommandMenu = "MENU";
        public RoundService()
        {
        }

        public void Begin()
        {
            CreateTwoTeams();
            Continue();
        }

        public void Continue()
        {
            while (TeamB.IsAllUnitsAlive && TeamA.IsAllUnitsAlive && !IsExitDone)
                HitStepByStep();

            if (IsExitDone)
            {
                IsExitDone = false;
                return;
            }

            DisplayWinner();
        }
        public void CreateTwoTeams()
        {
            TeamGeneratorService teamGenerator = new TeamGeneratorService();
            TeamA = teamGenerator.GenerateTeamA();
            TeamB = teamGenerator.GenerateTeamB();
            IsTeamATurn = true;
        }

        private bool IsInputValid(bool isInteger, int number)
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
        }

        private void DisplayWinner()
        {
            if (TeamA.IsAllUnitsAlive)
                TeamA.PrintAliveUnits();
            else if (TeamB.IsAllUnitsAlive)
                TeamB.PrintAliveUnits();
        }

        private void HitStepByStep()
        {
            if (IsTeamATurn)
            {
                var player = TeamA.GetRandomAliveUnit();
                if (!player.IsStunned)
                {
                    DisplayFightDialog();
                    if (IsExitDone)
                    {
                        return;
                    }
                    Console.WriteLine($"Your opponent is {ChosenOpponent}");
                }
                player.Attack(TeamB.AliveUnits[ChosenOpponent]);
            }
            else
                TeamB.GetRandomAliveUnit().Attack(TeamA.GetRandomAliveUnit());

            IsTeamATurn = !IsTeamATurn;
            Console.WriteLine();
        }

        public void DisplayFightDialog()
        {
            while (true)
            {
                Console.WriteLine($"Enter number beetwen 0 and {TeamB.AliveUnits.Count - 1} or menu command");
                var input = Console.ReadLine();
                ExecuteCommand(input);

                if (IsCommandExecuted)
                {
                    IsCommandExecuted = false;
                    return;
                }

                if (ValidateInput(input))
                    return;
            }
        }

        public bool ValidateInput(string input)
        {
            var isInteger = Int32.TryParse(input, out var number);
            if (IsInputValid(isInteger, number))
            {
                ChosenOpponent = number;
                return true;
            }
            return false;
        }

        private void ExecuteCommand(string command)
        {
            switch (command.ToUpper())
            {
                case CommandMenu:
                    Console.WriteLine("You exit in main menu!");
                    IsCommandExecuted = true;
                    IsExitDone = true;
                    break;
            }
        }
    }
}
