using Exam_6_Heroes_And_Magic.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic.Models
{
    class Army
    {
        List<IUnit> AllUnits { get; set; }

        private void Generate(String colour)
        {
            List<IUnit> readTeam = new List<IUnit>();
            List<IUnit> blueTeam = new List<IUnit>();
        }

    }

}


