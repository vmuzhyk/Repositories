using Painkiller.Models;
using Painkiller.Models.Abstract;

namespace Painkiller.Services
{
    internal class Avenger : Unit
    {
        public Avenger(int maxHealth, int damage, string name, Team team) : base(maxHealth, damage, name, team)
        {
        }
    }
}