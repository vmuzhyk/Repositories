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
            List<IMortable> allUnits = new List<IMortable>
            {
                new Crusader(300, 30, "Bernard"),
                new Assassin(150, 50, "Menny"),
            };
            Army yellowArmy = new Army("Yellow", allUnits);
            return yellowArmy;
        }

        public Army GenerateTeamB()
        {
            List<IMortable> allUnits = new List<IMortable>
            {
                new Crusader(300, 30, "Jeremy"),
                new Assassin(150, 50, "Kevin"),
            };
            Army violetArmy = new Army("Violet", allUnits);
            return violetArmy;
        }
    }
}
