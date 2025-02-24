using System;
using System.Security.Cryptography;

namespace Classes
{
    public class Calculator8
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double A1 { get; set; }
        public double B1 { get; set; }
        public double C1 { get; set; }



        public Calculator8(double a, double b, double c, double a1, double b1, double c1)
        {
            A = a;
            B = b;
            C = c;
            A1 = a1;
            B1 = b1;
            C1 = c1;
        }
        public bool CalculateA()
        {
            double p = (A + B + C) / 2;
            double p1 = (A1 + B1 + C1) / 2;
            double s = Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            double s1 = Math.Sqrt(p1 * (p1 - A1) * (p1 - B1) * (p1 - C1));
            return s > s1;
        }
    }
}
