using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2_Alien_Invading_Refactoring
{
    public class War
    {
        private Gamer Peter { get; set; }
        private Swarm Swarm { get; set; }

        public War()
        {
            Peter = new Gamer(100, 20);
            Swarm = new Swarm(1, 10);
        }

        public void Begin()
        {
            Swarm.DisplayListOfAliens();
            while (Peter.IsAlive() && Swarm.IsAlive())
            {
                BattleStep();
            }
        }

        private void BattleStep()
        {
            var chosenAlien = ChooseEnemy();
            Swarm.ReceiveDamage(chosenAlien, Peter.SizeOfAttack);
            Swarm.DisplayListOfAliens();
            AttackGamer();
            
        }

        private void AttackGamer()
        {
            foreach(Alien alien in Swarm.Aliens)
            {
                Peter.RemoveLives(alien.SizeOfAttack);
            }
        }

        private int ChooseEnemy()
        {
            Console.WriteLine($"Enter number from 0 to {Swarm.Aliens.Count}");
            var input = Console.ReadLine();
            int item = int.Parse(input);
            return item;
        }

        
    }
}
