using System;
using System.Collections.Generic;
using System.Text;

namespace Exams_10_Chaos_League.Models.Abstract
{
    public abstract class Unit
    {
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int Damage { get; set; }
    }
}
