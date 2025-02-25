namespace Classes
{
    public class Calculator27
    {
        public int A { get; set; }
        public int B { get; set; }

        public Calculator27(int a, int b)
        {
            A = a;
            B = b;
        }

        public int CalculateA()
        {
            return ProductDigits(A) * ProductDigits(B);
        }

        private int ProductDigits(int number)
        {
            int product = 1;
            while (number != 0)
            {
                product *= number % 10;
                number /= 10;
            }
            return product;
        }
    }
}