using System;

namespace Exam_6_Heroes_And_Magic.Services
{
    internal class GameService
    {
        private RoundService _roundService;
        public GameService()
        {

        }

        internal void Begin()
        {
            RoundService round = new RoundService();
            round.Begin();
        }
    }
}