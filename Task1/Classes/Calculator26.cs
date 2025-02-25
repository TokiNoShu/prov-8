namespace Classes
{
    public class Calculator26
    {
        public int A { get; set; }
        public int B { get; set; }

        public Calculator26(int a, int b)
        {
            A = a;
            B = b;
        }

        public int CalculateA()
        {
            return SumDigits(A) + SumDigits(B);
        }

        private int SumDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
    }
}