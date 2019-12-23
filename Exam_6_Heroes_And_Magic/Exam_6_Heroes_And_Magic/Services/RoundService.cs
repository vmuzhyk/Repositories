using Exam_6_Heroes_And_Magic.Models;
using Exam_6_Heroes_And_Magic.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic.Services
{
    public class RoundService
    {
        private Army TeamA { get; set; }
        private Army TeamB { get; set; }
        private bool IsTeamBTurn { get; set; }

        public RoundService ()
        {
            ArmyGeneratorService armyGenerator = new ArmyGeneratorService();
            TeamA = armyGenerator.GenerateTeamA();
            TeamB = armyGenerator.GenerateTeamB();
            ChooseFirstTurn();
        }

        private void ChooseFirstTurn()
        {
            Random rand = new Random();
            int index = rand.Next(0, 2);
            IsTeamBTurn = index == 0 ? true : false;
        }

        public void Begin()
        {
            while (TeamB.IsAllUnitsAlive && TeamA.IsAllUnitsAlive)
                HitStepByStep();

            DisplayWinner();
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
            if (IsTeamBTurn)
                TeamB.GetRandomAliveUnit().Attack(TeamA);
            else
                TeamA.GetRandomAliveUnit().Attack(TeamB);

            IsTeamBTurn = !IsTeamBTurn;
            Console.WriteLine();
        }
    }
}
