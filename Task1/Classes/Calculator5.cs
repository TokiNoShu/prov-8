namespace Classes
{
    public class Calculator5
    {
        public int Month { get; set; }

        public Calculator5(int month)
        {
            Month = month;
        }

        public string CalculateA()
        {
            if (Month >= 3 && Month <= 5)
                return "Весна";
            else if (Month >= 6 && Month <= 8)
                return "Лето";
            else if (Month >= 9 && Month <= 11)
                return "Осень";
            else
                return "Зима";
        }
    }
}