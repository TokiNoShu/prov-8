using System;

namespace Classes
{
    public class Calculator5
    {
        public int A { get; set; }

        public Calculator5(int a)
        {
            A = a;
        }
        public string CalculateA()
        {
            if (A >= 3 && A <= 5)
                return "Весна";
            else if (A >= 6 && A <= 8)
                return "Лето";
            else if (A >= 9 && A <= 11)
                return "Осень";
            else if (A == 12 || (A <= 2 && A > 0))
                return "Зима";
            else return "Такого месяца не существует";
        }
    }
}
