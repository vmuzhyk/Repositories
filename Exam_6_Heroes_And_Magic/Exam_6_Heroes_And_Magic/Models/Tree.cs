using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam_6_Heroes_And_Magic.Models.Abstract;

namespace Exam_6_Heroes_And_Magic.Models
{
    public class Tree : IUnit
    {
        public string Name { get; }

        public Army Team { get; }

        public int Height { get; set; }
        public int GrowingSpeed { get; }


        public Tree(string name, Army team, int height, int growingSpeed)
        {
            Name = name;
            Team = team;
            Height = height;
            GrowingSpeed = growingSpeed;
        }

        public string GetInfoExtended()
        {
            return $"{this.Team.Name}: {this.GetType().Name} {this.Name}";
        }

        public void ActEachTurn()
        {
            Height += GrowingSpeed;
            Console.WriteLine($" {GetInfoExtended()} growing to {Height}");
        }

    }
}
