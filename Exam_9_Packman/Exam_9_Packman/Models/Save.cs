using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_9_Packman.Models
{
    public class Save
    {

        public List<Player> Scores { get; set; }

        public Save(List<Player> scores)
        {
            Scores = scores;
        }
    }
}
