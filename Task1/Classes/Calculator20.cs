using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Calculator20
    {
        public double A { get; set; }
        public double B { get; set; }
        public Calculator20(double a, double b)
        {
            A = a;
            B = Math.Pow(b, -3);
        }
        public double LiterSpeed()
        {
            return A * 0.001;
        }
        public double MeterSpeed()
        {
            return B / 60;
        }
        public bool CalculateA()
        {
            return LiterSpeed() > MeterSpeed();
        }
    }
}
