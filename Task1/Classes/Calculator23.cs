using System.Collections.Generic;
using System;

namespace Classes
{
    public class Calculator23
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public Calculator23(int a, int b, int c)
        {
            A = a;
            B = b;
            C = c;
        }

        public int[] CalculateA()
        {
            int binaryNumber = Convert.ToInt32("1101011", 2);
            List<int> result = new List<int>();

            if (A > binaryNumber) result.Add(A);
            if (B > binaryNumber) result.Add(B);
            if (C > binaryNumber) result.Add(C);

            return result.ToArray();
        }
    }
}