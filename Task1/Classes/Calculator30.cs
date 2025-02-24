namespace Classes
{
    public class Calculator30
    {
        public int AI { get; set; }

        public Calculator30(int ai)
        {
            AI = ai;
        }
        public double CalculateA()
        {
            if (AI > 0)
            {
                if (AI % 2 == 0)
                {
                    return 1;
                }
                else if (AI % 10 == 7)
                {
                    return 2;
                }
                else return 0;
            }
            else return 0;
        }
    }
}
