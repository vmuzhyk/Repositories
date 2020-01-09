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
                /*new Crusader(300, 30, "Bernard", team),
                new Assassin(150, 50, "Menny", team),
                new Cerberus (70, 25, "Robert", team),
                *//*new Crusader(300, 30, "Andrew", team),
                new Assassin(150, 50, "Pall", team),
                new Cerberus (70, 25, "Lili", team),*//*
                new WizardWarrior (120, 25, "Richard", team, 100, 35, 150),
                new WizardHealer (150, 0, "Gektor", team, 100, 35),
                new Elf(110, 45, "Miriam", team),
                new Tree ("William", team, 0, 15),*/
            };
            team.AllUnits = allUnits;
            return team;
        }

        public Team GenerateTeamB()
        {
            Team team = new Team("Characters");
            List<IUnit> allUnits = new List<IUnit>
            {
                /*new Crusader(300, 30, "Jeremy", team),
                new Assassin(150, 50, "Kevin", team),
                new Cerberus (70, 25, "Henry", team),
               *//* new Crusader(300, 30, "Lex", team),
                new Assassin(150, 50, "Danny", team),
                new Cerberus (70, 25, "Juliya", team),*//*
                new WizardWarrior (120, 25, "David", team, 100, 35, 150),
                new WizardHealer (150, 0, "Gordon", team, 100, 35),
                new Elf(110, 45, "Jenny", team),
                new Tree ("Kile", team, 0, 20),*/
            };
            team.AllUnits = allUnits;
            return team;
        }
    }
}