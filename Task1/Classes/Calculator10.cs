using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Calculator10
    {
        public int A { get; set; }
        public string B { get; set; }




        public Calculator10(int a, string b)
        {
            A = a;
            B = b;
        }
        public string CalculateA()
        {
            if (A >= 1 && A <= 3 && (B == "a" || B == "b" || B == "c"))
                return $"открытка {A}, вариант {B}";
            else return "номер 1-3 и вариант a, b, c";
        }
    }
}
