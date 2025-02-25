namespace Classes
{
    public class Calculator15
    {
        public double X { get; set; }
        public double Y { get; set; }


        public Calculator15(double x, double y)
        {
            X = x;
            Y = y;

        }
        public bool CalculateA()
        {
            return X >= 0 && Y <= 0;
        }
    }
}
