using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Calculator10
    {
        public double K { get; set; }
        public double L { get; set; }
        public double M { get; set; }




        public Calculator10(double k, double l, double m)
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
                    arr[i] = Math.Pow(arr[i], 3);
                else arr[i] = 0;
            }
            return arr;
        }
    }
}
