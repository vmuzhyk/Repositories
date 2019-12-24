using Exam_6_Heroes_And_Magic.Models.Abstract;
using Exam_6_Heroes_And_Magic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic.Models
{
    public class Army 
    {
        public List<MeleeUnitBase> AllUnits { get; }
        public string Name { get; }
        public List<MeleeUnitBase> AliveUnits => AllUnits.Where(unit => unit.IsAlive).ToList();
       
                
        public bool IsAllUnitsAlive { get => AliveUnits.Count > 0; }

        public Army(string name, List<MeleeUnitBase> allUnits)
        {
            AllUnits = allUnits;
            Name = name;
        }


        public void PrintAliveUnits()
        {
            Console.WriteLine($" Army Name: {Name} win. Alive Units: { AliveUnits.Count}");
            AliveUnits.ForEach(unit => Console.WriteLine($" {unit.GetInfoBasic()}, current health {unit.CurrentHealth}")); 
        }

        public void ActEachTurn()
        {
            AliveUnits.ForEach(unit => unit.ActEachTurn());
        }
    }

}


