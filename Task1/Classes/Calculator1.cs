using System;

namespace Classes
{
    public class Calculator1
    {
        public double X {  get; set; }
        public double Y { get; set; }


        public Calculator1(double x, double y) 
        {
            X = X;
            Y = y;

        }
        public bool CalculateA()
        {
            double parabolaY = 2 - X * X;
            return Y >= 0 && Y <= parabolaY;
        }
    }
}
