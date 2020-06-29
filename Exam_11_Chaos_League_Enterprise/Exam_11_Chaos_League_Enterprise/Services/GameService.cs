using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_11_Chaos_League_Enterprise.Services
{
    public class GameService
    {
        public RoundService _roundService = new RoundService();
        public void Start()
        {
            _roundService.Begin();
        }
    }
}
