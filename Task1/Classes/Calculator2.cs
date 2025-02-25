namespace Classes
{
    public class Calculator2
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Calculator2(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public double CalculateA()
        {
            return (A + B + C) / 3;
        }
    }
}