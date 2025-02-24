using System;
using System.Runtime.Remoting.Lifetime;
using System.Security.Cryptography;

namespace Classes
{
    public class Calculator2
    {
        double A { get; set; }
        double B { get; set; }
        double C { get; set; }

        public Calculator2(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double CalculateA()
        {
            double[] nums = { A, B, C };
            double bigger = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > bigger)
                {
                    bigger = i;
                }
            }
            return bigger;
        }
    }
}
