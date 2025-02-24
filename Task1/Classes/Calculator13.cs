using System;

namespace Classes
{
    public class Calculator13
    {
        public double A;
        public double B;
        public double C;

        public Calculator13(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double[] CalculateA()
        {
            double[] middleNums = { };
            double middle = (A + B + C) / 3;
            double[] nums = { A, B, C };
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > middle)
                    middleNums[i] = nums[i];
            }
            return middleNums;
        }
    }
}
