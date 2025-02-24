using System;

namespace Classes
{
    public class Calculator28
    {
        public double A { get; set; }


        public Calculator28(double a)
        {
            A = a;
        }
        public bool CalculateA()
        {
            while (A > 360)
            {
                A -= 360;
            }
            return A > 0 && A < 180;
        }
    }
}
