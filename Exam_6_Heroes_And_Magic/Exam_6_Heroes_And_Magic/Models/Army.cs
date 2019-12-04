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
        public List<IMortable> AllUnits { get; set; }
        private string Name { get; set; }
        public IMortable RundomAliveUnit { get => AliveUnits[new Random().Next(AliveUnits.Count)];}
        public List<IMortable> AliveUnits => AllUnits.Where(unit => unit.IsAlive).ToList();
        public bool IsAllUnitsAlive { get => AllUnits.Any(unit => unit.IsAlive); }

        public Army (String name)
        {
            AllUnits = new List<IMortable>()
            {
                new Crusader(300, 30),
            };
            Name = name;
        }

    }

}


