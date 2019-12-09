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
        public List<IMortable> AllUnits { get; }
        public string Name { get; }
        public List<IMortable> AliveUnits => AllUnits.Where(unit => unit.IsAlive).ToList();
        private Random _random;
        /* public IMortable RundomAliveUnit
         {
             get
             {
                 int item = new RundomService().Get(AliveUnits.Count);
                 Console.WriteLine($"AliveUnits.Count {AliveUnits.Count}");
                 Console.WriteLine($"Item is {item}");
                 return AliveUnits[item];
             }
         }*/

        public IMortable GetRundomAliveUnit(int index)
        {
            return AliveUnits[index];
        }
        public bool IsAllUnitsAlive { get => AliveUnits.Count > 0; }

        public Army(string name, List<IMortable> allUnits)
        {
            AllUnits = allUnits;
            Name = name;
            _random = new Random();
        }

        

        public void PrintAliveUnits()
        {
            Console.WriteLine($" Army Name: {Name} win. Alive Units: { AliveUnits.Count}");
            AliveUnits.ForEach(unit => {
                IUnit unitWithName = (IUnit)unit;
                Console.WriteLine($" {unitWithName.GetType().Name} {unitWithName.Name}, current health {unit.CurrentHealth}");
                }); 
        }

    }

}


