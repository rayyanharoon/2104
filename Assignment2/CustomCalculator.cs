﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment2.Interfaces;

namespace Assignment2
{
    public class CustomCalculator : ICalculator
    {
        public int Calculate(int x)
        {
            return ((x * x) + 8) / 2;
        }
    }
}
