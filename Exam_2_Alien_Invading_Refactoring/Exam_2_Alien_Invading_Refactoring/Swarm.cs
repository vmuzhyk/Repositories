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
            if (Aliens.Count > 0)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Congratulations!!! You are WINNER!!! Yeh!!!");
                return false;
            }
        }


        public void ReceiveDamage(int chosenAlien, int sizeOfAttack)
        {
            foreach (Alien item in Aliens)
            {
                if (item.Id == chosenAlien)
                {
                    item.RemoveLives(sizeOfAttack);
                    
                }
            }
            Aliens.RemoveAll(x => !x.IsAlive());
        }
    }
}
