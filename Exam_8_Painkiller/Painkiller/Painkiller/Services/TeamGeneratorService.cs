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
            List<IUnit> allUnits = new List<IUnit>
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
            List<IUnit> allUnits = new List<IUnit>
            {
                new Skeleton (80, 30, "Moomba", team),
                new Monk (120, 25, "Joomba", team, 50, 20),
                new Necromant (200, 15, "Matoomba", team, 20),
            };
            team.AllUnits = allUnits;
            return team;
        }
    }

}