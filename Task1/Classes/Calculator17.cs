namespace Classes
{
    public class Calculator17
    {
        public double AX { get; set; }
        public double AY { get; set; }




        public Calculator17(double ax, double ay)
        {
            AX = ax;
            AY = ay;
        }
        public bool CalculateA()
        {
            return AX > 0 && AY < 0;
        }
    }
}
