using Exam_11_Chaos_League_Enterprise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_11_Chaos_League_Enterprise.Services
{
    public class RoundService
    {
        List<Army> Armies { get; set; }

        
        public RoundService()
        {
            Armies = new List<Army>()
            {
                new Army("Humans"),
                new Army("Necromants"),
                new Army("Pretorians"),
                new Army("Orcs"),
                new Army("Elfs"),
                new Army("Demons"),
                new Army("Barbarians"),
                new Army("Dwarfs")
            };
        }

        public void Begin()
        {
            PrintFightField();
        }

        private void PrintFightField()
        {
            Armies.ForEach(army => Console.WriteLine(army));
        }
    }
}
