namespace Exercise5
{
    public class CurrencyCalculator
    {
        public static double ConvertToEuros(double pounds)
        {
            return Math.Round(pounds * 0.83, 2);
        }

        public static double ConvertToPounds(double euros)
        {
            return Math.Round(euros * 1.2, 2);
        }
    }
}