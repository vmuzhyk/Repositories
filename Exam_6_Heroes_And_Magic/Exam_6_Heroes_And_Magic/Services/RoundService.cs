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
        private Random _random;

        public RoundService ()
        {
            _random = new Random();
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

        public int GetRandomNumber (int maxCount)
        {
            var item = _random.Next(maxCount);
            Console.WriteLine($"Item is {item}");
            return item;
        }

        /*public IMortable GetRundomAliveUnitTeamA()
        {
            var item = _random.Next(TeamA.AliveUnits.Count);
            Console.WriteLine($"AliveUnits.Count {TeamA.AliveUnits.Count}");
            Console.WriteLine($"Item is {item}");
            return TeamA.AliveUnits[item];
        }

        public IMortable GetRundomAliveUnitTeamB()
        {
            var item = _random.Next(TeamB.AliveUnits.Count);
            Console.WriteLine($"AliveUnits.Count {TeamB.AliveUnits.Count}");
            Console.WriteLine($"Item is {item}");
            return TeamB.AliveUnits[item];
        }*/

        private void HitStepByStep()
        {
            if (IsTeamBTurn)
                PerformAttack((MeleeUnitBase)TeamB.GetRundomAliveUnit(GetRandomNumber(TeamB.AliveUnits.Count)), (MeleeUnitBase)TeamA.GetRundomAliveUnit(GetRandomNumber(TeamA.AliveUnits.Count)), TeamA.Name, TeamB.Name);
            else
                PerformAttack((MeleeUnitBase)TeamA.GetRundomAliveUnit(GetRandomNumber(TeamA.AliveUnits.Count)), (MeleeUnitBase)TeamB.GetRundomAliveUnit(GetRandomNumber(TeamB.AliveUnits.Count)), TeamB.Name, TeamA.Name);

            IsTeamBTurn = !IsTeamBTurn;
        }

        private void PerformAttack(MeleeUnitBase attacker, MeleeUnitBase defender, string defenderTeamName, string attackerTeamName)
        {   
            defender.RemoveHealth(attacker, defenderTeamName, attackerTeamName);
        }
    }
}
