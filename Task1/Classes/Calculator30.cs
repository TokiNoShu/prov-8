using System;

namespace Classes
{
    public class Calculator30
    {
        public double R1 { get; set; }
        public double R2 { get; set; }
        public double R3 { get; set; }

        public Calculator30(double r1, double r2, double r3)
        {
            R1 = r1;
            R2 = r2;
            R3 = r3;
        }

        public string CalculateA()
        {
            double resistorValue = 6;
            double series = resistorValue + resistorValue;
            double parallel = 1 / (1 / resistorValue + 1 / resistorValue);

            if (Math.Abs(R1 - series) < 0.1 || Math.Abs(R1 - parallel) < 0.1)
                return "Можно получить с помощью двух резисторов";
            else
                return "Нельзя получить с помощью двух резисторов";
        }
    }
}