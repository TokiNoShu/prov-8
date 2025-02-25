using System;

namespace Classes
{
    public class Calculator29
    {
        public double Resistance { get; set; }
        public double Current { get; set; }

        public Calculator29(double resistance, double current)
        {
            Resistance = resistance;
            Current = current;
        }

        public string CalculateA()
        {
            double voltage = 45;
            double requiredResistance = voltage / Current;

            if (Math.Abs(Resistance - requiredResistance) < 0.1)
                return "Реостат подходит";
            else
                return "Реостат не подходит";
        }
    }
}