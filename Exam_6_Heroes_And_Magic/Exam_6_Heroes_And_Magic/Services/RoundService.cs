using Exam_6_Heroes_And_Magic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic.Services
{
    public class RoundService
    {
        private Crusader yellowCrusader { get; set; }
        private Crusader violetCrusader { get; set; }
        private bool IsvioletCrusaderTurn { get; set; }

        public RoundService ()
        {
            yellowCrusader = new Crusader(300, 30);
            violetCrusader = new Crusader(300, 30);
        }
    }
}
