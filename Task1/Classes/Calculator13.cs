using System.Collections.Generic;
using System;

namespace Classes
{
    public class Calculator13
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Calculator13(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double[] CalculateA()
        {
            double average = (Math.Abs(X) + Math.Abs(Y) + Math.Abs(Z)) / 3;
            List<double> result = new List<double>();

            if (Math.Abs(X) > average) result.Add(X);
            if (Math.Abs(Y) > average) result.Add(Y);
            if (Math.Abs(Z) > average) result.Add(Z);

            return result.ToArray();
        }
    }
}