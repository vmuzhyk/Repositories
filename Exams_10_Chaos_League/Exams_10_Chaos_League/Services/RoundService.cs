using Exams_10_Chaos_League.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams_10_Chaos_League.Services
{
    public class RoundService
    {
        public List<Army> Teams { get; set; }
 
        public RoundService()
        {
            Teams = new List<Army>
            {
                new Army("Humans"),
                new Army("Necromants"),
                new Army("Pretorians")
            };

        }
        internal void Begin()
        {
            DisplayFightField(); 
        }
        public void DisplayFightField()
        {
            Teams.ForEach(army => Console.WriteLine(army));
        }
    }
}
