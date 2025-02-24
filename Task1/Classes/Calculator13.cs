using System;

namespace Classes
{
    public class Calculator13
    {
        public double A;
        public double B;
        public double C;

        public Calculator13(double a, double b)
        {
            A = a;
            B = b;
            if (A >= 6 && A < 12)
            {
                C = 1 + 0.6/12;
            }
            else if(A >= 12)
            {
                C = 1 + 0.6/12;
            }
        }
        public double CalculateA()
        {
            return (B * C - B) * A;
        }
    }
}
