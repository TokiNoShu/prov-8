using System;

namespace Classes
{
    public class Calculator7
    {
        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }

        public Calculator7(double x1, double y1, double x2, double y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public bool CalculateA()
        {
            double distance1 = Math.Sqrt(X1 * X1 + Y1 * Y1);
            double distance2 = Math.Sqrt(X2 * X2 + Y2 * Y2);
            return distance1 > distance2;
        }
    }
}