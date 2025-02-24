using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Calculator19
    {
        public int A { get; set; }
        public int B { get; set; }
        public int C { get; set; }

        public Calculator19(int ai, int bi, int ci)
        {
            A = (int)Math.Pow(ai, 2);
            B = (int)Math.Pow(bi, 2);
            C = (int)Math.Pow(ci, 2);
        }
        public bool CalculateA()
        {
            return C == A + B || A == C + B || B == A + C;
        }
    }
}