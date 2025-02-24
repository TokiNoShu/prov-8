namespace Classes
{
    public class Calculator12
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Calculator12(double a, double b, double c)
        {
            A = a; 
            B = b;
            C = c;
        }
        public double CalculateA()
        {
            double minimum = A;
            double[] nums = { A, B, C };
            for (int i = 0; i < nums.Length; i++)
            {
                if (minimum < i)
                {
                    minimum = nums[i];
                }
            }
            return minimum;
        }
    }
}
