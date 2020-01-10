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
                new Avenger (300, 30, "John Doe", team),
            };
            team.AllUnits = allUnits;
            return team;
        }

        public Team GenerateTeamB()
        {
            Team team = new Team("Characters");
            List<IUnit> allUnits = new List<IUnit>
            {
                new Skeleton (150, 30, "Moomba", team),
                
            };
            team.AllUnits = allUnits;
            return team;
        }
    }

}