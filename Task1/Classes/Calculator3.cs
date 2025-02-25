namespace Classes
{
    public class Calculator3
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double R { get; set; }

        public Calculator3(double x, double y, double r)
        {
            X = x;
            Y = y;
            R = r;
        }

        public bool CalculateA()
        {
            return X * X + Y * Y <= R * R;
        }
    }
}