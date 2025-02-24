namespace Classes
{
    public class Calculator6
    {
        public double AX { get; set; }
        public double AY { get; set; }


        public Calculator6(double ax, double ay)
        {
            AX = ax;
            AY = ay;
        }
        public double CalculateA()
        {
            if (AX == 0 || AY == 0)
            {
                return 0;
            }
            else
            {
                if (AX > 0)
                {
                    if (AY > 0)
                    {
                        return 1;
                    }
                    else return 4;
                }
                else
                {
                    if (AY < 0)
                    {
                        return 2;
                    }
                    else return 3;
                }
            }
        }
    }
}
