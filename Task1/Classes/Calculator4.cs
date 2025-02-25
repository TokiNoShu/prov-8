using System;

namespace Classes
{
    public class Calculator4
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Calculator4(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public bool CalculateA()
        {
            double[] sides = { A, B, C };
            Array.Sort(sides);
            return Math.Abs(sides[2] * sides[2] - (sides[0] * sides[0] + sides[1] * sides[1])) < 0.0001;
        }
    }
}