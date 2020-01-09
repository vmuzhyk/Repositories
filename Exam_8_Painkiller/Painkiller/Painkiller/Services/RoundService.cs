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
        private bool IsTeamBTurn { get; set; }

        public RoundService()
        {
            TeamGeneratorService armyGenerator = new TeamGeneratorService();
            TeamA = armyGenerator.GenerateTeamA();
            TeamB = armyGenerator.GenerateTeamB();
            ChooseFirstTurn();
        }

        private void ChooseFirstTurn()
        {   
            IsTeamBTurn = new Random().Next(0, 2) == 0 ? true : false;
        }
        public void Begin()
        {
            while (TeamB.IsAllUnitsAlive && TeamA.IsAllUnitsAlive) { }
                //HitStepByStep();

            //DisplayWinner();
        }
    }
}
