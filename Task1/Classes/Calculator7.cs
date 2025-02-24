using System;

namespace Classes
{
    public class Calculator7
    {
        public double AX { get; set; }
        public double AY { get; set; }
        public double R { get; set; }


        public Calculator7(double ax, double ay, double r)
        {
            AX = ax;
            AY = ay;
            R = r;
        }
        public bool CalculateA()
        {
            return AX < R && AX > -R && AY < R && AY > -R;
        }
    }
}
