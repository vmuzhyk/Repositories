using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_2_Alien_Invading_Refactoring
{
    class Swarm 
    {
        public List<Alien> Aliens { get; private set; }

        public Swarm(int minQuantity, int maxQuantity)
        {
            var rand = new Random();
            int numberAliens = rand.Next(minQuantity, maxQuantity);
            Aliens = new List<Alien>();
            for (int i = 0; i < numberAliens; i++)
            {
                Alien alien = new Alien(15, 10, i);
                Aliens.Add(alien);
            }
            Console.WriteLine($"Number Aliens is {numberAliens}"); 
         }

        public void DisplayListOfAliens()
        {
            Aliens.ForEach(alien => Console.WriteLine($"Alien {alien.Id} lives {alien.Lives}"));
        }

        public bool IsAlive()
        {
            return Aliens.Count > 0;
        }

        public void ReceiveDamage(int chosenAlien, int sizeOfAttack)
        {
            //var alien = Aliens.Where(x => x.Id == chosenAlien).First();
            
            Alien alien = null;
            foreach (Alien item in Aliens)
            {
                if (item.Id == chosenAlien)
                {
                    item.RemoveLives(sizeOfAttack);
                    
                }
            }
            if (alien != null)
            {
                bool isAlive = alien.IsAlive();
                if (!isAlive)
                {
                    Aliens.Remove(alien);
                }
            }
        }
    }
}
