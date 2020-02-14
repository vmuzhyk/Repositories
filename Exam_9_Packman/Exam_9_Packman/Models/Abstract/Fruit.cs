using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_9_Packman.Models.Abstract
{
    public abstract class Fruit : IItems
    {
        public int Coast { get; set; }
        

        public Fruit (int coast)
        {
            Coast = coast;
        }
    }
}
