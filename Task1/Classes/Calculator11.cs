namespace Classes
{
    public class Calculator11
    {
        public double A { get; set; }
        public double B { get; set; }


        public Calculator11(double a, double b)
        {
            A = a;
            B = b;
        }
        public double[] CalculateA()
        {
            if (A > 0 && B < 0)
            {
                A *= -1;
                B *= -1;
            }
            else A *= 0; B *= 0;
            double[] nums = { A, B};
            return nums;
        }
    }
}
