using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_7_Save_In_JSON
{
    public class Calculation
    {
        public int Sum { get; set; }
        public int Step { get; set; }

        public void Begin(string input)
        {
            var isInteger = Int32.TryParse(input, out var number);

            if (!IsInputValid(isInteger, number))
                return;

            CalcSum(number);

            DisplayScore();
        }

        public void DisplayScore()
        {
            Console.WriteLine($"Sum is {Sum}");
            Console.WriteLine($"Quantity of steps is {Step}");
        }
        private bool IsInputValid(bool isInteger, int number)
        {
            if (!isInteger)
            {
                Console.WriteLine("Number should be an integer value");
                return false;
            }

            if (number < 0 || number > 100 )
            {
                Console.WriteLine("Number should be between 0 and 100");
                return false;
            }

            return true;
        }

        public void CalcSum(int number)
        {
            Sum += number;
            Step++;
        }
               
    }
}
