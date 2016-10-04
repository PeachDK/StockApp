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
            string choice = "";
            bool running = true;
            do
            {
                Console.WriteLine("Make a choice:");
                Console.WriteLine("1: Browse Stock");
                Console.WriteLine("2: Search Stock");
                Console.WriteLine("3: Buy Stock");
                choice = Console.ReadLine();
                Console.Clear();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("List of Stock:");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Search for Stock");
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Buy Stock");
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
                Console.Clear();
            } while (running);

        }
    }
}
