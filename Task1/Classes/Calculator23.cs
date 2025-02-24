using System;

namespace Classes
{
    public class Calculator23
    {
        public double A { get; set; }
        public double B { get; set; }

        public Calculator23(double a, double b)
        {
            A = a;
            B = b;
        }
        public bool CalculateA()
        {
            return A > B * 3.6;
        }
    }
}
