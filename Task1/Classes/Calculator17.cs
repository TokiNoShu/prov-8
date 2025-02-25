namespace Classes
{
    public class Calculator17
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Calculator17(double x, double y)
        {
            X = x;
            Y = y;
        }

        public bool CalculateA()
        {
            return X > 0 && Y > 0;
        }
    }
}