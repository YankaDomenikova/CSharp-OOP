﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandPrix.Models.Tyres
{
    public class HardTyre : Tyre
    {
        public HardTyre(double hardness)
            : base("Hard", hardness)
        {
        }
    }
}
