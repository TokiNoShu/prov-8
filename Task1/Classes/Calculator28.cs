namespace Classes
{
    public class Calculator28
    {
        public double R1 { get; set; }
        public double R2 { get; set; }
        public double R3 { get; set; }

        public Calculator28(double r1, double r2, double r3)
        {
            R1 = r1;
            R2 = r2;
            R3 = r3;
        }

        public double[] CalculateA()
        {
            double series = R1 + R2 + R3;
            double parallel = 1 / (1 / R1 + 1 / R2 + 1 / R3);
            return new double[] { series, parallel };
        }
    }
}