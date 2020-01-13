using Painkiller.Models;
using Painkiller.Models.Abstract;

namespace Painkiller.Services
{
    public class Avenger : Unit
    {
        public bool IsStunned { get; set; }
        public Avenger(int maxHealth, int damage, string name, Team team) : base(maxHealth, damage, name, team)
        {
            IsStunned = false;
        }

        public override void ReceiveInfluence()
        {
            IsStunned = true;
        }
    }

}