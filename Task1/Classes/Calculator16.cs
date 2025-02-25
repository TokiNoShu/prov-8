using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Classes
{
    public class Calculator16
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Calculator16(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public bool CalculateA()
        {
            double[] minimum = { A, B, C }; 
            double p = (A + B + C) / 2;
            return Math.Sqrt(p*(p - A) * (p - B) * (p-C)) > Math.Pow(Math.Min(Math.Min(A, B), C), 2);
        }
    }
}
