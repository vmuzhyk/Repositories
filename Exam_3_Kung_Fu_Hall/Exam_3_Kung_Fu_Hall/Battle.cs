using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_3_Kung_Fu_Hall
{
    class Battle
    {
        private Fighter Strong { get; set; }
        private Fighter Healthy { get; set; }

        public Battle()
        {
            Strong = new Fighter(50, 10);
            Healthy = new Fighter(100, 5);
            //Console.WriteLine($"Strong's lives {Strong.Lives} and size of attack {Strong.SizeOfAttack}");
            //Console.WriteLine($"Healthy's lives {Healthy.Lives} and size of attack {Healthy.SizeOfAttack}");
        }

        public void Begin()
        {
            FirstHit();
        } 

        public void FirstHit()
        {
            Random rand = new Random();
            if (rand.Next(0, 2) == 0)
                Strong.HitOpponent();
            else
                Healthy.HitOpponent();
        }

        

    }
}
