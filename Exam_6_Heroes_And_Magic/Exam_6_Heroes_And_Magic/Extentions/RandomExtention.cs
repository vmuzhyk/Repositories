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

        public static MeleeUnitBase GetRandomAliveUnit(this Army army)
        {
            var random = _random.Next(army.AliveUnits.Count);
            //Console.WriteLine(" " + random);
            return army.AliveUnits[random];
        }
        public static List<MeleeUnitBase> GetRandomAliveUnit(this Army army, int count)
        {
            var randomUnits = army.AliveUnits.OrderBy(x => _random.Next()).Take(count).ToList();
            //foreach (var unit in randomUnits)
            //Console.WriteLine($" Random Unit is {unit.GetInfoExtended()}");
            
            return randomUnits;
        }


    }
}
