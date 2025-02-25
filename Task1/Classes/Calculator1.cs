namespace Classes
{
    public class Calculator1
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Calculator1(double x, double y)
        {
            X = x;
            Y = y;
        }

        public bool CalculateA()
        {
            return Y >= 0 && Y <= X * X;
        }
    }
}