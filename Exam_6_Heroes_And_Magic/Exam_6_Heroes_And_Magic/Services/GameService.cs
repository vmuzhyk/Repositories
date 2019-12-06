using System;

namespace Exam_6_Heroes_And_Magic.Services
{
    internal class GameService
    {
        private readonly RoundService _roundService;
        public GameService()
        {
            _roundService = new RoundService();
        }

        internal void Begin()
        {
            
            _roundService.Begin();
        }
    }
}