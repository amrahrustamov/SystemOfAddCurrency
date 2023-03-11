using System.Net.Security;

namespace Terminalda_mezenne__idareetme_sistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] currencyListNumbers = new int[5]   { 1,     2,     3,      4,      5};
            string[] currencyCodes = new string[5] { "USD", "RUB", "TRY" , "EURO", "CNY"};
            double[] exchangeRate = new double[5]  { 1.7000, 0.0224, 0.0898, 1.8011, 0.2441 };
            char[] letter = new char[] { };
            ////////////////////////////////////////////////////////////////////////////////
            
            int[] menuNumbers = new int[4];
            menuNumbers[0] = 1;
            menuNumbers[1] = 2;
            menuNumbers[2] = 3;
            menuNumbers[3] = 4;

            //Console.WriteLine(" " + "Menu");
            //Console.WriteLine("");

            //Console.WriteLine(menuNumbers[0] + " " + "Show recent currency rates");
            //Console.WriteLine(menuNumbers[1] + " " + "Find currency rate by code");
            //Console.WriteLine(menuNumbers[2] + " " + "Calculate amount by currency");
            //Console.WriteLine(menuNumbers[3] + " " + "Exit");

            //Console.WriteLine("");
            //Console.Write("Select one : ");
            //Console.ReadLine();

            ////////////////////////////////////////////////////////////////////////////////

            //Console.WriteLine("");
            //Console.WriteLine(" " + "Menu");
            //Console.WriteLine("");

            //Console.WriteLine(menuNumbers[0] + " " + "Show recent currency rates");
            //Console.WriteLine(menuNumbers[1] + " " + "Find currency rate by code");
            //Console.WriteLine(menuNumbers[2] + " " + "Calculate amount by currency");
            //Console.WriteLine(menuNumbers[3] + " " + "Exit");

            //Console.WriteLine("");
            //Console.Write("Select one : ");
            //int selectMenuNumber = int.Parse(Console.ReadLine());

            /////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("");
            Console.WriteLine(" " + "Menu" + " / " + "Show recent currency rates");
            Console.WriteLine("");


            Console.Write("Add currency code : ");
            string addCurrencyCode = Console.ReadLine();
            Console.WriteLine("");
            

            
            if (currencyCodes[0].Contains(addCurrencyCode) ||
                  currencyCodes[1].Contains(addCurrencyCode) ||
                  currencyCodes[2].Contains(addCurrencyCode) ||
                  currencyCodes[3].Contains(addCurrencyCode) ||
                  currencyCodes[4].Contains(addCurrencyCode))
            {
                if (currencyCodes[0].Contains(addCurrencyCode))
                {
                    Console.WriteLine(currencyCodes[0] + " " + exchangeRate[0]);
                }
                if (currencyCodes[1].Contains(addCurrencyCode))
                {
                    Console.WriteLine(currencyCodes[1] + " " + exchangeRate[1]);
                }
                if (currencyCodes[2].Contains(addCurrencyCode))
                {
                    Console.WriteLine(currencyCodes[2] + " " + exchangeRate[2]);
                }
                if (currencyCodes[3].Contains(addCurrencyCode))
                {
                    Console.WriteLine(currencyCodes[3] + " " + exchangeRate[3]);
                }
                if (currencyCodes[4].Contains(addCurrencyCode))
                {
                    Console.WriteLine(currencyCodes[4] + " " + exchangeRate[4]);
                }
            }


            ////////////////////////////////////////////////////////////////////
            ///
















            //Console.WriteLine("This code is not available in our system");




        }
    }
}