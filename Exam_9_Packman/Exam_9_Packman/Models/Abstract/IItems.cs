using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_9_Packman.Models.Abstract
{
    public interface IItems
    {
        void InteractionWithPlayer(Player player);
        void CalcProbabilityToInteract(Player player);
    }
}
