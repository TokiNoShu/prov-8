using System;
using System.Runtime.InteropServices;

namespace Classes
{
    public class Calculator16
    {
        public double AX { get; set; }
        public double AY { get; set; }
        public double R { get; set; }
        public double R1 { get; set; }

        public Calculator16(double ax, double ay, double r, double r1)
        {
            AX = Math.Abs(ax);
            AY = Math.Abs(ay);
            R = Math.Abs(r);
            R1 = Math.Abs(r1);
        }
        public bool CalculateA()
        {
            return AX < R && AX > R1 && AY < R && AY > R1;
        }
    }
}
