using System;

namespace Classes
{
    public class Calculator25
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public Calculator25(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public int CalculateA()
        {
            return Math.Min(Math.Min(A, B), C);
        }
    }
}