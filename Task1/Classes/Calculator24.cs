﻿using System;

namespace Classes
{
    public class Calculator24
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public Calculator24(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public int CalculateA()
        {
            return Math.Max(Math.Max(A, B), C);
        }
    }
}