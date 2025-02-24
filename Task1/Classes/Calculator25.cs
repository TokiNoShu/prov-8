namespace Classes
{
    public class Calculator25
    {
        public double R { get; set; }
        public double U { get; set; }
        public double R1 { get; set; }
        public double U1 { get; set; }


        public Calculator25(double r, double u, double r1, double u1)
        {
            R = r;
            U = u;
            R1 = r1;
            U1 = u1;
        }
        public bool CalculateA()
        {
            return U / R > U1 / R1;
        }
    }
}
