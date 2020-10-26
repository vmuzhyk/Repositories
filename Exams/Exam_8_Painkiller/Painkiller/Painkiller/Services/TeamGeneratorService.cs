using Painkiller.Models;
using Painkiller.Models.Abstract;
using System.Collections.Generic;

namespace Painkiller.Services
{
    public class TeamGeneratorService
    {
        public Team GenerateTeamA()
        {
            Team team = new Team ("Players");
            List<Unit> allUnits = new List<Unit>
            {
                new Avenger (300, 15, "Lily Doe", team),
                new Avenger (300, 15, "John Doe", team),
            };
            team.AllUnits = allUnits;
            return team;
        }

        public Team GenerateTeamB()
        {
            Team team = new Team("Characters");
            List<Unit> allUnits = new List<Unit>
            {
                new Skeleton (120, 30, "Moomba", team),
                new Monk (140, 25, "Joomba", team, 50, 20),
                new Necromant (200, 15, "Matoomba", team, 50),
            };
            team.AllUnits = allUnits;
            return team;
        }
    }

}