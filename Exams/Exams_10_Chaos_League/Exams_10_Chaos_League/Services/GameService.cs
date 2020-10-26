using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exams_10_Chaos_League.Services
{
    public class GameService
    {
        private readonly RoundService _roundService;

        public GameService()
        {
            _roundService = new RoundService();
            //DisplayWelcomeMessage();
        }
        internal void Begin()
        {
            _roundService.Begin();
        }
    }
}
