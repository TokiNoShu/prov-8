using System;

namespace Classes
{
    public class Calculator15
    {
        public double AX { get; set; }
        public double AY { get; set; }
        public double BX { get; set; }
        public double BY { get; set; }



        public Calculator15(double ax, double ay, double bx, double by)
        {
            AX = ax;
            AY = ay;
            BX = bx;
            BY = by;
        }
        public bool CalculateA()
        {
            return AX + AY < BX + BY;
        }
    }
}
