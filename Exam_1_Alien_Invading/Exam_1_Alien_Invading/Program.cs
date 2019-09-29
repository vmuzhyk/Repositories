using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_1_Alien_Invading
{
    class Program
    {
        public static int CrateSwarm()
        {
            var rand = new Random();
            int numberAliens = rand.Next(1, 10);
            Alien[] swarm = new Alien[numberAliens];
            for (int i = 0; i < swarm.Length; i++)
            {
                swarm[i] = new Alien();
            }
            Console.WriteLine(numberAliens);
            int quantity = swarm.Length;
            return quantity;
        }
        static void ListOfAliens(int x)
        {
            for ( int i = 0; i < x; i++)
            {

            }
        }
        static void AtackEnemy ()
        {

        }
        static void Main(string[] args)
        {
            Gamer Peter = new Gamer();
            int create = CrateSwarm();
            ListOfAliens(create);
            Console.ReadKey();
        }
    }
}
