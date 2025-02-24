using System.Data;

namespace Classes
{
    public class Calculator6
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }


        public Calculator6(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public double[] CalculateA()
        {
            double[] nums = { A, B, C };
            if (A + B + C > 0)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] *= 2;
                }
            }
            else for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = 0;
                }
            return nums;
        }
    }
}
