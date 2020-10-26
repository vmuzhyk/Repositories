using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_3_Kung_Fu_Hall
{
    class Hall
    {
        private int RangeOfFights { get; }
        
        public Hall()
        {
            RangeOfFights = ChooseRangeOfFights();
            var tasks = new List<Task>();
            for (int i = 1; i <= RangeOfFights; i++)
            {
               Battle battle = new Battle();
               tasks.Add(battle.Begin());
            }
            Task.WaitAll(tasks.ToArray());
            Console.WriteLine("Done");
        }

        private int ChooseRangeOfFights()
        {
            try
            {
                Console.WriteLine("Enter number from 1 to 100");
                var input = Console.ReadLine();
                int range = int.Parse(input);
                if (range < 1 || range > 1000)
                {
                    throw new ArgumentException();
                }
                return range;
            }
            catch (Exception ex) when (ex is ArgumentException || ex is FormatException)
            { 
                Console.WriteLine("You did not enter a namber. Enter number from 1 to 5 one more time");
                return ChooseRangeOfFights();
            }
        }
    }
}
