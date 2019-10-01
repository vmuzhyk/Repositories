using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_1_Alien_Invading
{
    class Program
    {
        public static Alien[] CrateSwarm()
        {
            var rand = new Random();
            int numberAliens = rand.Next(1, 10);
            Alien[] swarm = new Alien[numberAliens];
            for (int i = 0; i < swarm.Length; i++)
            {
                swarm[i] = new Alien();
            }
            Console.WriteLine(numberAliens);
            return swarm;
        }

        static void ListOfAliens(Alien[] swarm)
        {
            for ( int i = 0; i < swarm.Length; i++)
            {
                Console.WriteLine($"Alien {i} {swarm[i]}");
            }
        }

        static int ChooseEnemy (Alien[] swarm)
        {
            Console.WriteLine($"Enter number from 0 to {swarm.Length - 1}");
            var input = Console.ReadLine();
            int item = int.Parse(input);
            return item;
        }

        static Alien[] AttackEnemy (int chosenAlien, Alien[] swarm, Gamer peter)
        {
            swarm[chosenAlien].RemoveLives(peter.sizeOfAttack);
            Alien[] survivors = EnemyDies(swarm);
            ListOfAliens(survivors);
            return survivors;
        }

        static void AttackGamer (Alien[] swarm, Gamer peter)
        {
            foreach (Alien alien in swarm)
            {
                peter.RemoveGamersLives(alien.sizeOfAttack);
            }
            Console.WriteLine($"Peter's lives after current attack is {peter.Lives}");
        }

        static Alien[] BattleStep(Alien[] swarm, Gamer peter)
        {
            var chosenAlien = ChooseEnemy(swarm);
            Alien[] swarmSurv = AttackEnemy(chosenAlien, swarm, peter);
            AttackGamer(swarmSurv, peter);
            return swarmSurv;
        }

        static Alien[] EnemyDies (Alien[] swarm)
        {
            Alien[] survivors = swarm.Where(alien => alien.Lives > 0).ToArray();
            return survivors;
         }

        static bool IsGamerAlive (Gamer peter)
        {
            if (peter.Lives <= 0)
            {
                Console.WriteLine("Game over!!! You are LOOSER!!! Ha Ha!!!");
                return false;
            } else
            {
                return true;
            }
        }

        static bool IsSwarmAlive(Alien[] swarm)
        {
            if (swarm.Length <= 0)
            {
                Console.WriteLine("Congratulations!!! You are WINNER!!! Yeh!!!");
                return false;
            }
            else
            {
                return true;
            }
        }

        static void StillWar (Alien [] swarm,Gamer peter)
        {
            while (IsGamerAlive(peter) && IsSwarmAlive(swarm))
            {
                swarm = BattleStep(swarm, peter);
            }
        }

        static void Main(string[] args)
        {
            Gamer peter = new Gamer();
            var swarm = CrateSwarm();
            ListOfAliens(swarm);
            StillWar(swarm, peter);
            Console.ReadKey();
        }
    }
}
