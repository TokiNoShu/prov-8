using System;

namespace Classes
{
    public class Calculator24
    {
        public double A { get; set; }
        public double R { get; set; }
        public double sSq;
        public double sCir;
        public Calculator24(double a, double r)
        {
            A = a;
            R = r;
            sSq = Math.Pow(A, 2) * Math.Sqrt(3 / 4);
            sCir = Math.PI * Math.Pow(R, 2);
        }
        public bool CalculateA()
        {
            return sSq > sCir;
        }
    }
}
