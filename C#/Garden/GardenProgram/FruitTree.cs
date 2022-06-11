﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GardenProgram
{
    public abstract class FruitTree : Tree, IFood
    {
        public double Energy { get; set; }
    }
}
