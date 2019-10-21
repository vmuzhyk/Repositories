using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_4_Chu_Va_Chi
{
    class Round
    {
        private Player Human { get; }
        private Player Computer { get; }
        private int DrawCount { get; set; }

        public Round()
        {
            Human = new Player(0);
            Computer = new Player(0);
            Console.WriteLine($"Human wins {Human.WinsCount} and Computer wins {Computer.WinsCount}, DrawCount {DrawCount}");
        }
        public bool BeginRound()
        {
            bool isExit = HumanChooseElement();
            Console.WriteLine($"Human's choice {Human.Choice}");
            ComputerChooseElement();
            CalculateWinner();
            Console.WriteLine($"Human wins {Human.WinsCount} and Computer wins {Computer.WinsCount}, DrawCount {DrawCount}");
            return isExit;
        }

        public Elements ChosenElement (int  index)
        {   
            switch (index)
            {
                case 0:
                    return Elements.Stone;
                case 1:
                    return Elements.Paper;
                case 2:
                    return Elements.Scissors;
                default:
                    throw new ArgumentException();
            }
        }

        public bool HumanChooseElement()
        {
            Console.WriteLine("Enter number from 0 to 2");
            var input = Console.ReadLine();
            if ((input == "Exit") || (input == "exit")){
                return true;
            } 
            try
            {   
                int index = int.Parse(input);
                Human.Choice = ChosenElement(index);
            }
            catch (Exception ex) when (ex is ArgumentException || ex is FormatException)
            {
                Console.WriteLine("You did not enter a number. Enter number from 0 to 2 one more time");
                HumanChooseElement();
            }
            return false;
        }
        
        public void ComputerChooseElement()
        {
            Random rand = new Random();
            int index = rand.Next(0, 3);
            Computer.Choice = ChosenElement(index);
            Console.WriteLine($"Computers's choice {Computer.Choice}");
        }

        public void CalculateWinner()
        {
           if (((Human.Choice == Elements.Stone) && (Computer.Choice == Elements.Paper)) 
                || ((Human.Choice == Elements.Paper) && (Computer.Choice == Elements.Scissors)) 
                || ((Human.Choice == Elements.Scissors) && (Computer.Choice == Elements.Stone)))
            {
                Computer.WinsCount++;
            } else if (((Human.Choice == Elements.Stone) && (Computer.Choice == Elements.Scissors))
                || ((Human.Choice == Elements.Paper) && (Computer.Choice == Elements.Stone)) 
                || ((Human.Choice == Elements.Scissors) && (Computer.Choice == Elements.Paper)))
            {
                Human.WinsCount++;
            } else if (((Human.Choice == Elements.Paper) && (Computer.Choice == Elements.Paper))
                || ((Human.Choice == Elements.Stone) && (Computer.Choice == Elements.Stone)) 
                || ((Human.Choice == Elements.Scissors) && (Computer.Choice == Elements.Scissors)))
            {
                DrawCount++;
            }
        }

    }
}
