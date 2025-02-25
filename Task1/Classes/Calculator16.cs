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

        public string CalculateA()
        {
            double minSide = Math.Min(Math.Min(A, B), C);
            double triangleArea = 0.25 * Math.Sqrt((A + B + C) * (A + B - C) * (A + C - B) * (B + C - A));
            double squareArea = minSide * minSide;

            return triangleArea > squareArea ? "Площадь треугольника больше" : "Площадь квадрата больше";
        }
    }
}