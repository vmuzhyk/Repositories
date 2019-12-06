using Exam_6_Heroes_And_Magic.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic.Models
{
    public class Army 
    {
        public List<IMortable> AllUnits { get; }
        private string Name { get; set; }
        public List<IMortable> AliveUnits => AllUnits.Where(unit => unit.IsAlive).ToList();
        public IMortable RundomAliveUnit { get => AliveUnits[new Random().Next(AliveUnits.Count)];}
        public bool IsAllUnitsAlive { get => AliveUnits.Count > 0; }

        public Army(string name, List<IMortable> allUnits)
        {
            AllUnits = allUnits;
            Name = name;
        }

        public override string ToString()
        {
            var fightInfo = $"ArmyName: {Name}  AliveUnits: {AliveUnits.Count}";
            return fightInfo;
        }
    }

}


