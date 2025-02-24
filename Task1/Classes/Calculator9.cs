using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Calculator9
    {
        public double A { get; set; }
        public double R { get; set; }

        public Calculator9(double a, double r)
        {
            A = a;
            R = r;
        }
        public bool CalculateA()
        {
            return Math.Pow(A, 2) > (Math.Pow(R, 2) * Math.PI);
        }
    }
}
