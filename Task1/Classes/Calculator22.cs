using System;

namespace Classes
{
    public class Calculator22
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Calculator22(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double CalculateA()
        {
            return Math.Min(Math.Min(A, B), C);
        }
    }
}