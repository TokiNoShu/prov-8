using System;

namespace Classes
{
    public class Calculator5
    {
        public double K { get; set; }
        public double L { get; set; }
        public double M { get; set; }




        public Calculator5(double k, double l, double m)
        {
            K = k;
            L = l;
            M = m;
        }
        public double[] CalculateA()
        {
            double[] arr = { K, L, M };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                    arr[i] = Math.Pow(arr[i], 2);
            }
            return arr;
        }
    }
}
