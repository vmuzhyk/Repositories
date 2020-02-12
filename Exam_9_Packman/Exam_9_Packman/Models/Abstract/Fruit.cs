using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_9_Packman.Models.Abstract
{
    public abstract class Fruit : IFruit
    {
        public int Coast { get; set; }
        public int PercentAppearance { get; set; }

        public Fruit (int coast, int percentAppearance)
        {
            Coast = coast;
            PercentAppearance = percentAppearance;
        }
    }
}
