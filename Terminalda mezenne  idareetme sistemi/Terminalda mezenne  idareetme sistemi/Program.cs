using System.Net.Security;

namespace Terminalda_mezenne__idareetme_sistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] currencyListNumbers = new int[5] { 1, 2, 3, 4, 5 };
            string[] currencyCodes = new string[5] { "USD", "RUB", "TRY", "EURO", "CNY" };
            double[] exchangeRate = new double[5] { 1.7000, 0.0224, 0.0898, 1.8011, 0.2441 };
            ////////////////////////////////////////////////////////////////////////////////
            
            string showRecentCurrencyRates = "Show recent currency rates";
            string findCurrencyRateByCode = "Find currency rate by code";
            string calculateAmountByCurrency = "Calculate amount by currency";
            string exit = "Exit";
            
            while (true)
            {
                Console.WriteLine(" " + "Menu");
                Console.WriteLine("");
                Console.WriteLine("Show recent currency rates");
                Console.WriteLine("Find currency rate by code");
                Console.WriteLine("Calculate amount by currency");
                Console.WriteLine("Exit");
                Console.WriteLine("");
                Console.Write("Select one : ");
                string command = Console.ReadLine();
                ////////////////////////////////////////////////////////////////////////
                if (command == showRecentCurrencyRates)
                {
                    Console.WriteLine("");
                    Console.WriteLine(" " + "Menu" + " / " + "Show recent currency rates");
                    Console.WriteLine("");
                    Console.WriteLine(currencyCodes[0] + " " + exchangeRate[0]);
                    Console.WriteLine(currencyCodes[1] + " " + exchangeRate[1]);
                    Console.WriteLine(currencyCodes[2] + " " + exchangeRate[2]);
                    Console.WriteLine(currencyCodes[3] + " " + exchangeRate[3]);
                    Console.WriteLine(currencyCodes[4] + " " + exchangeRate[4]);
                    Console.WriteLine("");
                }
                /////////////////////////////////////////////////////////////////////////////
                if (command == findCurrencyRateByCode)
                {
                    Console.WriteLine("");
                    Console.WriteLine(" " + "Menu" + " / " + "Find currency rate by code");
                    Console.WriteLine("");
                    Console.Write("Add currency code : ");
                    string addCurrencyCode = Console.ReadLine();
                    Console.WriteLine("");

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

                    if(!currencyCodes[0].Contains(addCurrencyCode) || currencyCodes[4].Contains(addCurrencyCode) ||
                       currencyCodes[4].Contains(addCurrencyCode) || currencyCodes[4].Contains(addCurrencyCode) ||
                       currencyCodes[4].Contains(addCurrencyCode))
                    {   
                        Console.WriteLine("This code is not available in our system");
                    }
                }
                ///////////////////////////////////////////////////////////////////////////
                if (command == calculateAmountByCurrency)
                {
                    Console.WriteLine("");
                    Console.WriteLine(" " + "Menu" + " / " + "Calculate amount by currency");
                    Console.WriteLine("");

                    Console.Write("Add the amount : ");
                    double amount = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Add the currency code : ");
                    string addCurrencyCode = Console.ReadLine();
                    Console.WriteLine("");

                    if (currencyCodes[0].Contains(addCurrencyCode))
                    {
                        double result = exchangeRate[0] * amount;
                        Console.WriteLine("Result : " + result + " AZN");
                    }
                    if (currencyCodes[1].Contains(addCurrencyCode))
                    {
                        double result = exchangeRate[1] * amount;
                        Console.WriteLine("Result : " + result + " AZN");
                    }
                    if (currencyCodes[2].Contains(addCurrencyCode))
                    {
                        double result = exchangeRate[2] * amount;
                        Console.WriteLine("Result : " + result + " AZN");
                    }
                    if (currencyCodes[3].Contains(addCurrencyCode))
                    {
                        double result = exchangeRate[3] * amount;
                        Console.WriteLine("Result : " + result + " AZN");
                    }
                    if (currencyCodes[4].Contains(addCurrencyCode))
                    {
                        double result = exchangeRate[4] * amount;
                        Console.WriteLine("Result : " + result + " AZN");
                    }
                    if (!currencyCodes[0].Contains(addCurrencyCode) || currencyCodes[4].Contains(addCurrencyCode) ||
                       currencyCodes[4].Contains(addCurrencyCode) || currencyCodes[4].Contains(addCurrencyCode) ||
                       currencyCodes[4].Contains(addCurrencyCode))
                    {
                        Console.WriteLine("This code is not available in our system");
                    }
                }
                    if (command == exit)
                    {
                        break;
                    }
            }



















        }   }
}