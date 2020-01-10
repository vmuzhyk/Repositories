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

        public RoundService()
        {
            TeamGeneratorService armyGenerator = new TeamGeneratorService();
            TeamA = armyGenerator.GenerateTeamA();
            TeamB = armyGenerator.GenerateTeamB();
            ChooseOpponentForAttack();
        }

        private void ChooseOpponentForAttack()
        {   
            IsTeamATurn = new Random().Next(0, 2) == 0 ? true : false;
        }
        public void Begin(string input)
        {
            while (TeamB.IsAllUnitsAlive && TeamA.IsAllUnitsAlive)
            {
                var isInteger = Int32.TryParse(input, out var number);

                if (!IsInputValid(isInteger, number))
                    return;
            }

                //HitStepByStep();

            DisplayWinner();
        }

        private bool IsInputValid(bool isInteger, int number)
        {
            if (!isInteger)
            {
                Console.WriteLine("Number should be an integer value");
                return false;
            }

            if (number < 0 || number > TeamB.AliveUnits.Count )
            {
                Console.WriteLine($"Number should be between 0 and {TeamB.AliveUnits.Count}");
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
            /*if (IsTeamBTurn)
                TeamB.GetRandomAliveUnit().Attack(TeamA);
            else
                TeamA.GetRandomAliveUnit().Attack(TeamB);

            IsTeamBTurn = !IsTeamBTurn;*/
            Console.WriteLine();
        }
    }
}
