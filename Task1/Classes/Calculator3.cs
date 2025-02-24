using System;

namespace Classes
{
    public class Calculator3
    {
        public double AX { get; set; }
        public double AY { get; set; }
        public double BX { get; set; }
        public double BY { get; set; }



        public Calculator3(double ax, double ay, double bx, double by)
        {
            AX = ax;
            AY = ay;
            BX = bx;
            BY = by;
        }
        public bool CalculateA()
        {
            return Math.Abs(AX + AY) > Math.Abs(BX + BY);
        }
    }
}
