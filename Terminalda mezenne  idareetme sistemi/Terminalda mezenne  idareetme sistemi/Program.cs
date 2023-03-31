using System.Data;
using System.Net.Security;

namespace Terminalda_mezenne__idareetme_sistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] currencyCodes = new string[5] { "USD", "RUB", "TRY", "EUR", "CNY" };
            double[] exchangeRate = new double[5] { 1.7000, 0.0224, 0.0898, 1.8011, 0.2441 };
            ////////////////////////////////////////////////////////////////////////////////
            string showRecentCurrencyRates = "Show recent currency rates";
            string findCurrencyRateByCode = "Find currency rate by code";
            string calculateAmountByCurrency = "Calculate amount by currency";
            string exit = "Exit";

            while (true)
            {
                Console.WriteLine("");
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
                    ExecuteShowRecentCurrencyRates(currencyCodes, exchangeRate);
                }
                ////////////////////////////////////////////////////////////////////////
                if (command == findCurrencyRateByCode)
                {
                    ExecuteFindCurrencyRateByCode(currencyCodes, exchangeRate);
                }
                ////////////////////////////////////////////////////////////////////////
                if (command == calculateAmountByCurrency)
                {
                    ExecuteCalculateAmountByCurrency(currencyCodes, exchangeRate, command);
                }
                if (command == exit)
                {
                    Console.WriteLine("###############################");
                    Console.WriteLine("Thank you for using our app");
                    Console.WriteLine("");
                    Console.WriteLine("Bye Bye");
                    break;
                }
            }
        }
        public static void ExecuteShowRecentCurrencyRates(string[] currencyCodes,double[] exchangeRate)
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
        public static void ExecuteFindCurrencyRateByCode(string[] currencyCodes, double[] exchangeRate)
        {
            Console.WriteLine("");
            Console.WriteLine(" " + "Menu" + " / " + "Find currency rate by code");
            Console.WriteLine("");
            Console.Write("Add currency code : ");
            string command = Console.ReadLine();
            Console.WriteLine("");

            if (command == currencyCodes[0])
            {
                Console.WriteLine(currencyCodes[0] + " " + exchangeRate[0]);
                return;
            }
            if (command == currencyCodes[1])
            {
                Console.WriteLine(currencyCodes[1] + " " + exchangeRate[1]);
                return;
            }
            if (command == currencyCodes[2])
            {
                Console.WriteLine(currencyCodes[2] + " " + exchangeRate[2]);
                return;
            }
            if (command == currencyCodes[3])
            {
                Console.WriteLine(currencyCodes[3] + " " + exchangeRate[3]);
                return;
            }
            if (command == currencyCodes[4])
            {
                Console.WriteLine(currencyCodes[4] + " " + exchangeRate[4]);
                return;
            }

            if (command != currencyCodes[0] || command != currencyCodes[1] ||
               command != currencyCodes[2] || command != currencyCodes[3] ||
               command != currencyCodes[4])
            {
                Console.WriteLine("This code is not available in our system");
            }
        }
        public static void ExecuteCalculateAmountByCurrency(string[] currencyCodes, double[] exchangeRate, string command)
        {
            Console.WriteLine("");
            Console.WriteLine(" " + "Menu" + " / " + "Calculate amount by currency");
            Console.WriteLine("");

            Console.Write("Add the amount : ");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Add the currency code : ");
            command = Console.ReadLine();
            Console.WriteLine("");

            if (command == currencyCodes[0])
            {
                double result = exchangeRate[0] * amount;
                Console.WriteLine("Result : " + result + " AZN");
                return;
            }
            if (command == currencyCodes[1])
            {
                double result = exchangeRate[1] * amount;
                Console.WriteLine("Result : " + result + " AZN");
                return;
            }
            if (command == currencyCodes[2])
            {
                double result = exchangeRate[2] * amount;
                Console.WriteLine("Result : " + result + " AZN");
                return;
            }
            if (command == currencyCodes[3])
            {
                double result = exchangeRate[3] * amount;
                Console.WriteLine("Result : " + result + " AZN");
                return;
            }
            if (command == currencyCodes[4])
            {
                double result = exchangeRate[4] * amount;
                Console.WriteLine("Result : " + result + " AZN");
                return;
            }
            if (command != currencyCodes[0] || command != currencyCodes[1] ||
               command != currencyCodes[2] || command != currencyCodes[3] ||
               command != currencyCodes[4])
            {
                Console.WriteLine("This code is not available in our system");
            }
        }
    }   
}