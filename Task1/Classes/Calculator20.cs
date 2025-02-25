namespace Classes
{
    public class Calculator20
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public Calculator20(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public string CalculateA()
        {
            if (A == B && B == C)
                return "Равносторонний";
            else if (A == B || B == C || A == C)
                return "Равнобедренный";
            else
                return "Простой";
        }
    }
}