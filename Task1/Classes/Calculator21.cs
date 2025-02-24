using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Calculator21
    {
        public double A { get; set; }
        public double R { get; set; }
        public double sSq;
        public double sCir;
        public Calculator21(double a, double r)
        {
            A = a;
            R = r;
            sSq = Math.Pow(A, 2);
            sCir = Math.PI * Math.Pow(R, 2);
        }
        public bool CalculateA()
        {
            return sSq > sCir;
        }
    }
}
