using System;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StockApp
{
    class Menu
    {
        IFileRepository repository;
        
        public Menu()
        {
            repository = new FileStockRepository(new DirectoryInfo("mydata\\"));
        }
        
        public void Home()
        { 
            Console.WriteLine("Make a choice:");
            Console.WriteLine("1: Browse Stock");
            Console.WriteLine("2: Search Stock");
            Console.WriteLine("3: Buy Stock");
        }

        public void BuyStock()
        {
            String Symbol        = "";
            double PricePerShare = 0;
            int    NumShares     = 0;
            Stock  newStock;

            Console.WriteLine("Enter Stock Symbol");
            Symbol = Console.ReadLine();

            Console.WriteLine("Enter Price Per Share");
            PricePerShare = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Number of Shares");
            NumShares = Convert.ToInt32(Console.ReadLine());

            newStock = new Stock(Symbol, PricePerShare, NumShares);

            repository.SaveStock(newStock);

            Console.WriteLine("Stock has been Saved!");
        }

        public void ShowAllStocks()
        {
            ICollection list = repository.FindAllStocks();

            foreach(Stock stock in list)
            {
                Console.WriteLine("\t" + stock.Id.ToString() + ":  " +stock.ToString());
            }
        }
    }
}
