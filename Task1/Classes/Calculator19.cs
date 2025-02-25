namespace Classes
{
    public class Calculator19
    {
        public double Fi { get; set; }
        public double Lambda { get; set; }

        public Calculator19(double fi, double lambda)
        {
            Fi = fi;
            Lambda = lambda;
        }

        public string CalculateA()
        {
            string hemisphere = Fi >= 0 ? "Северное" : "Южное";
            hemisphere += Lambda >= 0 ? " Восточное" : " Западное";
            return hemisphere;
        }
    }
}