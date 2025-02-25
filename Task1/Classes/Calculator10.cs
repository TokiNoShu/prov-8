namespace Classes
{
    public class Calculator10
    {
        public int Theme { get; set; }
        public string Variant { get; set; }

        public Calculator10(int theme, string variant)
        {
            Theme = theme;
            Variant = variant;
        }

        public string CalculateA()
        {
            string[] themes = { "Новогодние", "С Днем Рождения", "С Днем Защитника Отечества" };
            if (Theme < 1 || Theme > 3 || (Variant != "a" && Variant != "b" && Variant != "c"))
                return "Неправильный номер темы или варианта";
            return $"{themes[Theme - 1]}, вариант {Variant}";
        }
    }
}