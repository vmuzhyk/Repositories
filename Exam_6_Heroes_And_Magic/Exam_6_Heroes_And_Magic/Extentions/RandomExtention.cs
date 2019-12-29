using System;
using Exam_6_Heroes_And_Magic.Models.Abstract;
using Exam_6_Heroes_And_Magic.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic.Extentions
{
    public static class RandomExtention
    {
        private static Random _random;
        static RandomExtention()
        {
            _random = new Random();
        }

        public static UnitBase GetRandomAliveUnit(this Army army)
        {
            var random = _random.Next(army.AllFightAliveUnits.Count);
            //Console.WriteLine(" " + random);
            return army.AllFightAliveUnits[random];
        }
        public static List<UnitBase> GetRandomAliveUnits(this Army army, int count)
        {
            var randomUnits = army.AllFightAliveUnits.OrderBy(x => _random.Next()).Take(count).ToList();
            //foreach (var unit in randomUnits)
            //Console.WriteLine($" Random Unit is {unit.GetInfoExtended()}");
            
            return randomUnits;
        }

        public static int GenerateChance()
        {
            return _random.Next(1, 101);
        }

    }
}
