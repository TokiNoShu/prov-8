namespace Classes
{
    public class Calculator12
    {
        public double AX { get; set; }
        public double AY { get; set; }




        public Calculator12(double ax, double ay)
        {
            AX = ax; 
            AY = ay;
        }
        public bool CalculateA()
        {
            return AX > 0 && AY > 0;
        }
    }
}
