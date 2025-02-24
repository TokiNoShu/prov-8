using System;

namespace Classes
{
    public class Calculator26
    {
        public double MV { get; set; }
        public double RV { get; set; }
        public double MS { get; set; }
        public double RS { get; set; }
        public double G;

        public Calculator26(double mv, double rv, double ms, double rs)
        {
            MV = mv;
            RV = rv;
            MS = ms;
            RS = rs;
            G = 6.7 * Math.Pow(10, -8);
        }
        public bool CalculateA()
        {
            return G * MV / Math.Pow(RV, 2) > G * MS / Math.Pow(RS, 2);
        }
    }
}
