using System;

namespace Classes
{
    public class Calculator29
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C;

        public Calculator29(double a, double b)
        {
            A = a;
            B = b;
            C = B * 3259 * 9461000000000;
        }
        public bool CalculateA()
        {
            return A > C;
        }
    }
}
