using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_5_Chooce_a_film
{
    class ChoiceHelper
    {
        private int MinValue { get; }
        private int MaxValue { get; set; }
        private int ChosenFilm { get; set; }
        private int LineNumber { get; set; }
        private int LinePosition { get; set; }
        public ChoiceHelper ()
        {
            MinValue = 1;
        }

        public void Begin()
        {
            Console.WriteLine("Welcome to our Application");
            MaxValue = IsEnterValid();
            MaxValue++;
            RandomChoice();
            FindLineNumber();
            FindLinePosition();
        }
        private string AskMaxValue()
        {   
            Console.WriteLine();
            Console.Write("Enter a quantity of your future films: ");
            var input = Console.ReadLine();
            return input;
        }

        private int IsEnterValid()
        {
            while (true)
            {
                var input = AskMaxValue();
                var isInteger = Int32.TryParse(input, out var number);
                if (isInteger)
                    return number;

                Console.WriteLine("Number should be an integer value");
            }
        }

        private void RandomChoice()
        {
            Random rand = new Random();
            ChosenFilm = rand.Next(MinValue, MaxValue);
            Console.WriteLine($"Your chosen film is by number {ChosenFilm}");
        }

        private void FindLineNumber()
        {
            LineNumber = ChosenFilm / 6;
            Console.WriteLine($"Your chosen film is located in line {LineNumber}");
        }

        private void FindLinePosition() 
        {
            LinePosition = ChosenFilm - (LineNumber * 6);
            Console.WriteLine($"Your chosen film position is {LinePosition} in this line");
        }
    }
}
