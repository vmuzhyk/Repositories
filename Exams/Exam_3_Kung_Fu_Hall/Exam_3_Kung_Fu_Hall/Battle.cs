using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam_3_Kung_Fu_Hall
{
    class Battle
    {
        private Fighter Strong { get; }
        private Fighter Healthy { get; }
        private bool IsStrongTurn { get; set; }

        public Battle()
        {
            Strong = new Fighter(50, 10);
            Healthy = new Fighter(100, 5);
            ChooseFirstTurn();
        }

        public async Task Begin()
        {
            while (Strong.IsAlive() && Healthy.IsAlive())
            {
                await HitStepByStep();
            }
            Console.WriteLine($"Strong's lives {Strong.Lives} : Healthy's lives {Healthy.Lives}");
        }

        private void ChooseFirstTurn()
        {
            Random rand = new Random();
            int index = rand.Next(0, 2);
            IsStrongTurn = index == 0 ? true : false;
        }

        private async Task HitStepByStep()
        {
            if (IsStrongTurn)
                Healthy.RemoveLives(Strong.SizeOfAttack);
            else
                Strong.RemoveLives(Healthy.SizeOfAttack);
            await Task.Delay(500);
            IsStrongTurn = !IsStrongTurn;
        }
    }
}
