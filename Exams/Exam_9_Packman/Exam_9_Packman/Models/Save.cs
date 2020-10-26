using System.Collections.Generic;

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
