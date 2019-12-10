using System;
using Exam_6_Heroes_And_Magic.Models.Abstract;
using Exam_6_Heroes_And_Magic.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic.Services
{
    public class RandomService
    {
        private Random _random;
        public RandomService() 
        {
            _random = new Random();
        }

        public IMortable GetAliveUnit (Army army)
        {   
            var random = _random.Next(army.AliveUnits.Count);
            return army.AliveUnits[random]; 
        }

       
    }
}
