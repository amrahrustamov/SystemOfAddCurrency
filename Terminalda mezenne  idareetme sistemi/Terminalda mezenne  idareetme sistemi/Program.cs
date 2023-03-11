namespace Terminalda_mezenne__idareetme_sistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] currencyListNumbers = new int[5]   { 1,     2,     3,      4,      5};
            string[] currencyCodes = new string[5] { "USD", "RUB", "TRY" , "EURO", "CNY"};
            double[] exchangeRate = new double[5]  { 1.70, 0.0224, 0.0898, 1.8011, 0.2441 };
            ////////////////////////////////////////////////////////////////////////////////
            int[] menuNumbers = new int[4];
            menuNumbers[0] = 1;
            menuNumbers[1] = 2;
            menuNumbers[2] = 3;
            menuNumbers[3] = 4;

            Console.WriteLine(" " + "Menu");
            Console.WriteLine("");

            Console.WriteLine(menuNumbers[0] + " " + "Show recent currency rates");
            Console.WriteLine(menuNumbers[1] + " " + "Find currency rate by code");
            Console.WriteLine(menuNumbers[2] + " " + "Calculate amount by currency");
            Console.WriteLine(menuNumbers[3] + " " + "Exit");

            Console.WriteLine("");
            Console.Write("Select one : ");
            Console.ReadLine();
            ////////////////////////////////////////////////////////////////////////////////

        }
    }
}