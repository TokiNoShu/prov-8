namespace Classes
{
    public class Calculator4
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }



        public Calculator4(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }
        public bool CalculateA()
        {
            return A + B > C && A + C > B && B + C > A;
        }
    }
}
