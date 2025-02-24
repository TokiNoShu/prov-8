namespace Classes
{
    public class Calculator22
    {
        public double M {  get; set; }
        public double V { get; set; }
        public double M1 { get; set; }
        public double V1 { get; set; }


        public Calculator22(double m, double v, double m1, double v1) 
        {
            M = m;
            V = v;
            M1 = m1;
            V1 = v1;
        }
        public bool CalculateA()
        { 
            return M/V > M1/V1;
        }
    }
}
