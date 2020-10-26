using Painkiller.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painkiller.Models
{
    public class Save
    {
        public Team TeamA {  get; set; }
        public Team TeamB { get; set; }
        public bool IsTeamATurn { get; set; }
        public bool IsAnyChange { get; set; }
        public Save(Team teamA, Team teamB, bool isTeamATurn, bool isAnyChange)
        {
            this.TeamA = teamA;
            this.TeamB = teamB;
            this.IsTeamATurn = isTeamATurn;
            this.IsAnyChange = isAnyChange;
        }
    }
}
