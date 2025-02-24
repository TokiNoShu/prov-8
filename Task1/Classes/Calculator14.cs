using System;

namespace Classes
{
    public class Calculator14
    {
        public double A { get; set; }
        public double B { get; set; }


        public Calculator14(double a, double b)
        {
            A = a;
            B = b;

        }
        public bool CalculateA()
        {
            return Math.Pow(A, 2) - Math.Pow(B, 2) > Math.Abs(Math.Pow(A - B, 2));
        }
    }
}
