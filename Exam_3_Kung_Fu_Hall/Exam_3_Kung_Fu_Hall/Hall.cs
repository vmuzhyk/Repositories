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
            for (int i = 1; i <= RangeOfFights; i++)
            {
               Battle battle = new Battle();
               Task.Run(() => battle.Begin());
            }
            
        }

        public int ChooseRangeOfFights()
        {
            try
            {
                Console.WriteLine("Enter number from 1 to 5");
                var input = Console.ReadLine();
                int range = int.Parse(input);
                if (range < 1 || range > 101)
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
