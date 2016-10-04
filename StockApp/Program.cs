using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice   = "";
            bool   running  = true;
            Menu   menu     = new Menu();

            do
            {
                menu.Home();

                choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("List of Stock:");

                        menu.ShowAllStocks();

                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Search for Stock");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Buy Stock:");
                        menu.BuyStock();
                        Console.Read();
                        break;
                    default:
                        break;
                }
                Console.Clear();

            } while (running);

        }
    }
}
