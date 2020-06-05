using System;
using System.Collections.Generic;
using System.Text;

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
