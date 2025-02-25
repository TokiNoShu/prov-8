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
            if (A + B + C > 0)
            {
                A *= 2;
                B *= 2;
                C *= 2;
            }
            else
            {
                A = 0;
                B = 0;
                C = 0;
            }
            return new double[] { A, B, C };
        }
    }
}