using System;

namespace Classes
{
    public class Calculator14
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Calculator14(double x, double y)
        {
            X = x;
            Y = y;
        }

        public bool CalculateA()
        {
            double eps = 0.001;
            double curveY = Math.Abs(X) <= 2 ? X * X : 4;
            return Math.Abs(curveY - Y) <= eps;
        }
    }
}