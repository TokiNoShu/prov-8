using System;

namespace Classes
{
    public class Calculator2
    {
        public double A;
        public double B;
        public double C;

        public Calculator2(double a, double b)
        {
            A = a;
            B = b;
            if (A >= 2 && A < 5)
                C = 0.02;
            else if (A >= 5 && A <= 10)
                C = 0.05;
            else C = 1;
        }
        public double CalculateA()
        {
            return C;
        }
        public double CalculateB() 
        {
            return A + (A * C);
        }
    }
}
