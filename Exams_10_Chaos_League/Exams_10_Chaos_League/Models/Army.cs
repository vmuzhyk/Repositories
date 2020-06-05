using Exams_10_Chaos_League.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exams_10_Chaos_League.Models
{
    public class Army
    {
        public List<Unit> Cruiser { get; set; }

        public string Name { get; set; }
        public bool IsTeamMakeTurn { get; set; }
    }
}
