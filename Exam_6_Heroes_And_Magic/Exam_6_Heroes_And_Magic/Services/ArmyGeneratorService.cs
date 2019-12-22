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
            List<IMortable> allUnits = new List<IMortable>
            {
                new Crusader(300, 30, "Bernard", teamName),
                new Assassin(150, 50, "Menny", teamName),
                new Cerberus (70, 25, "Robert", teamName),
            };
            Army team = new Army(teamName, allUnits);
            return team;
        }

        public Army GenerateTeamB()
        {
            string teamName = "US";
            List<IMortable> allUnits = new List<IMortable>
            {
                new Crusader(300, 30, "Jeremy", teamName),
                new Assassin(150, 50, "Kevin", teamName),
                new Cerberus (70, 25, "Henry", teamName),
            };
            Army team = new Army(teamName, allUnits);
            return team;
        }
    }
}
