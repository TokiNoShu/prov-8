namespace Classes
{
    public class Calculator27
    {
        public double A { get; set; }


        public Calculator27(double a)
        {
            A = a;
        }
        public double CalculateA()
        {
            if (A >= 0 && A < 12) return 1;
            else if (A >=12 && A < 24) return 2;
            else return 0;
        }
    }
}
