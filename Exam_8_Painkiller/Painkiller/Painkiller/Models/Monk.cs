using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Painkiller.Models;
using Painkiller.Models.Abstract;

namespace Painkiller.Models
{
    public class Monk : Unit
    {
        public Monk (int maxHealth, int damage, string name, Team team) : base(maxHealth, damage, name, team)
        {
        }
    }
}
