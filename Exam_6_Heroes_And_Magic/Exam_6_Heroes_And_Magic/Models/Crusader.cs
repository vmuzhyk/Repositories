﻿using Exam_6_Heroes_And_Magic.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic.Models
{
    class Crusader : MeleeUnitBase
    {
        public Crusader (int maxHealth, int damage, string name) : base(maxHealth, damage, name)
        {

        }

    }
}
