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
            if (A * B < 0)
            {
                A = -A;
                B = -B;
            }
            else
            {
                A = 0;
                B = 0;
            }
            return new double[] { A, B };
        }
    }
}