﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class2
    {
        public int square(int x) {
            return x * x;
        }

        public int cube(int x) { 
            return square(x)*x;
        }
    }
}