using Painkiller.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painkiller.Models
{
    public class Skeleton : Unit
    {
        public Skeleton(int maxHealth, int damage, string name, Team team) : base(maxHealth, damage, name, team)
        {
        }
    }
}
