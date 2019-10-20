using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_4_Chu_Va_Chi
{
    class Round
    {
        private Elements ChosenElement { get; set; }

        public void ChooseElement()
        {
            Random rand = new Random();
            int index = rand.Next(0, 3);
            switch (index)
            {
                case 0:
                    ChosenElement = Elements.Stone;
                    break;
                case 1:
                    ChosenElement = Elements.Paper;
                    break;
                case 2:
                    ChosenElement = Elements.Scissors;
                    break;
                    
            }
            
        }
    }
}
