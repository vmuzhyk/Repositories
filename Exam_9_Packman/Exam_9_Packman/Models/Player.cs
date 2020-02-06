using Exam_9_Packman.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_9_Packman.Models
{
    class Player : IPlayer
    {
        public string Name { get; }
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int Score { get; set; }
        public int CrerryCount { get; set; }

    }
}
