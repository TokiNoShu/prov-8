namespace Classes
{
    public class Calculator3
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Calculator3(double x, double y)
        {
            X = x;
            Y = y;
        }

        public bool CalculateA()
        {
            double radius = 5; //Спроси у гвоздя про радиус
            return X * X + Y * Y <= radius * radius;
        }
    }
}