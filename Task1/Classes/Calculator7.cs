using System;

namespace Classes
{
    public class Calculator7
    {
        public double X0 { get; set; }
        public double Y0 { get; set; }
        public double X1 { get; set; }
        public double Y1 { get; set; }


        public Calculator7(double x0, double y0, double x1, double y1)
        {
            X0 = x0;
            Y0 = y0;
            X1 = x1;
            Y1 = y1;
        }
        public bool CalculateA()
        {
            return Math.Abs(X0 + Y0) > Math.Abs(X1 + Y1);
        }
    }
}
