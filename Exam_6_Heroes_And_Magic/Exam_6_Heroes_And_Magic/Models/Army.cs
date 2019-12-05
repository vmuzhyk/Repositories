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
        public List<IMortable> AliveUnits => AllUnits.Where(unit => unit.IsAlive).ToList();
        public IMortable RundomAliveUnit { get => AliveUnits[new Random().Next(AliveUnits.Count)];}
        public bool IsAllUnitsAlive { get => AliveUnits.Count > 0; }

        public Army (String name)
        {
            AllUnits = new List<IMortable>()
            {
                new Crusader(300, 30),
            };
            Name = name;
        }

        public override string ToString()
        {
            var fightInfo = $"ArmyName: {Name}  AliveUnits: {AliveUnits.Count}";
            return fightInfo;
        }
    }

}


