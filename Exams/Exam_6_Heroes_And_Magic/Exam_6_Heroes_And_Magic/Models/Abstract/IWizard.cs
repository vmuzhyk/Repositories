﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_6_Heroes_And_Magic.Models.Abstract
{
    interface IWizard
    {
        int CurrentMana { get; set; }
        int MaxMana { get; }

        int ImproveMana { get; }
        
        bool IsManaFull { get; }
    }
}
