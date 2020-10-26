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
        public List<IUnit> AllUnits { get; set; }
        public string Name { get; }

        public List<UnitBase> AllFightAliveUnits { get => GetAllFightUnits().Where(unit => unit.GetIsAlive()).ToList(); }
        public bool IsAllUnitsAlive { get => AllFightAliveUnits.Count > 0; }
        public UnitBase WeakUnit => AllFightAliveUnits.OrderBy(x => x.CurrentHealth).First();

        public Army(string name)
        {   
            Name = name;
        }

        public List<UnitBase> GetAllFightUnits()
        {
            var castedUnits = new List<UnitBase>();
            foreach(var unit in AllUnits)
            {
                if(unit is UnitBase)
                {
                    castedUnits.Add((UnitBase)unit);
                }
            }
            return castedUnits;
        }

        public void PrintAliveUnits()
        {
            Console.WriteLine($" Army Name: {Name} win. Alive Units: { AllFightAliveUnits.Count}");
            AllFightAliveUnits.ForEach(unit => Console.WriteLine($" {unit.GetInfoBasic()}, current health {unit.CurrentHealth}")); 
        }

        public void ActEachTurn()
        {
            GetActiveUnits().ForEach(unit => unit.ActEachTurn());
        }
        public List<IUnit> GetActiveUnits()
        {
            var activeUnits = new List<IUnit>();
            foreach (var unit in AllUnits)
            {
                if (unit is UnitBase)
                {
                    if(((UnitBase)unit).GetIsAlive())
                    activeUnits.Add(unit);
                } else
                {
                    activeUnits.Add(unit);
                }
            }
            return activeUnits;
        }
    }

}


