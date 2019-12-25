using Exam_6_Heroes_And_Magic.Models;
using Exam_6_Heroes_And_Magic.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic.Services
{
    public class ArmyGeneratorService
    {
        public Army GenerateTeamA()
        {
            string teamName = "GB";
            List<UnitBase> allUnits = new List<UnitBase>
            {
                new Crusader(300, 30, "Bernard", teamName),
                new Assassin(150, 50, "Menny", teamName),
                new Cerberus (70, 25, "Robert", teamName),
                new Crusader(300, 30, "Andrew", teamName),
                new Assassin(150, 50, "Pall", teamName),
                new Cerberus (70, 25, "Lili", teamName),
                new WizardWarrior (120, 25, 100, 25, "Richard", teamName),


            };
            Army team = new Army(teamName, allUnits);
            return team;
        }

        public Army GenerateTeamB()
        {
            string teamName = "US";
            List<UnitBase> allUnits = new List<UnitBase>
            {
                new Crusader(300, 30, "Jeremy", teamName),
                new Assassin(150, 50, "Kevin", teamName),
                new Cerberus (70, 25, "Henry", teamName),
                new Crusader(300, 30, "Lex", teamName),
                new Assassin(150, 50, "Danny", teamName),
                new Cerberus (70, 25, "Juliya", teamName),
                new WizardWarrior (120, 25, 100, 25, "David", teamName),
            };
            Army team = new Army(teamName, allUnits);
            return team;
        }
    }
}
