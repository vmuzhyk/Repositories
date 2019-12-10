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
                new Cerberus (70, 25, "Robert"),
                /*new Cerberus (70, 25, "Lili"),
                new Assassin(150, 50, "Pall"),
                new Crusader(300, 30, "Andrew"),*/

            };
            Army yellowArmy = new Army("GB", allUnits);
            return yellowArmy;
        }

        public Army GenerateTeamB()
        {
            List<IMortable> allUnits = new List<IMortable>
            {
                new Crusader(300, 30, "Jeremy"),
                new Assassin(150, 50, "Kevin"),
                new Cerberus (70, 25, "Henry"),
                /*new Cerberus (70, 25, "Juliya"),
                new Assassin(150, 50, "Danny"),
                new Crusader(300, 30, "Lex"),*/
            };
            Army violetArmy = new Army("US", allUnits);
            return violetArmy;
        }
    }
}
