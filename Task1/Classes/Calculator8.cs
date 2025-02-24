using System;
using System.Security.Cryptography;

namespace Classes
{
    public class Calculator8
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }



        public Calculator8(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public bool CalculateA()
        {
            return A == B || A == C || B == C;
        }
    }
}
