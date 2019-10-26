using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_4_Chu_Va_Chi
{
    public class Round
    {
        private Player Human { get; }
        private Player Machine { get; }

        public Round(Player human, Player machine)
        {
            Human = human;
            Machine = machine;
        }

        public void Begin(string input)
        {
            var isInteger = Int32.TryParse(input, out var number);

            if (!IsInputValid(isInteger, number))
                return;

            SelectWinner(number);

            Console.WriteLine($"Your score is {Human}");
            Console.WriteLine($"Machine score is {Machine}");
        }

        private bool IsInputValid(bool isInteger, int number)
        {
            if (!isInteger)
            {
                Console.WriteLine("Number should be an integer value");
                return false;
            }

            if (!Enum.IsDefined(typeof(Elements), number))
            {
                Console.WriteLine("Number should be between 0 and 2");
                return false;
            }

            return true;
        }

        private void SelectWinner(int number)
        {
            Human.Choice = (Elements)number;
            Console.WriteLine($"Your choice is {Human.Choice}");
            Random rand = new Random();
            int index = rand.Next(0, 3);
            Machine.Choice = (Elements)index; ;
            Console.WriteLine($"Machine's choice {Machine.Choice}");

            if (((Human.Choice == Elements.Stone) && (Machine.Choice == Elements.Paper))
                || ((Human.Choice == Elements.Paper) && (Machine.Choice == Elements.Scissors))
                || ((Human.Choice == Elements.Scissors) && (Machine.Choice == Elements.Stone)))
            {
                Machine.WinsCount++;
            }
            else if (((Human.Choice == Elements.Stone) && (Machine.Choice == Elements.Scissors))
              || ((Human.Choice == Elements.Paper) && (Machine.Choice == Elements.Stone))
              || ((Human.Choice == Elements.Scissors) && (Machine.Choice == Elements.Paper)))
            {
                Human.WinsCount++;
            }
            else if (((Human.Choice == Elements.Paper) && (Machine.Choice == Elements.Paper))
              || ((Human.Choice == Elements.Stone) && (Machine.Choice == Elements.Stone))
              || ((Human.Choice == Elements.Scissors) && (Machine.Choice == Elements.Scissors)))
            {
                Human.DrawCount++;
                Machine.DrawCount++;
            }
        }
    }
}
