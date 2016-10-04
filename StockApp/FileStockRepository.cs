using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _11_Files
{
    
    internal class FileStockRepository : IFileRepository
    {
        StockIO stockio = new StockIO();
        public long Id;
        private DirectoryInfo repositoryDir;
        public List<Stock> stocks = new List<Stock>();

        public FileStockRepository(DirectoryInfo repositoryDir)
        {
            this.repositoryDir = repositoryDir;
        }

        public long NextId()
        {
            return ++Id;
        }

        public void SaveStock(Stock asset)
        {
            asset.Id = NextId();               
            stockio.WriteStock(new FileInfo(StockFileName(asset.Id)), asset);
            stocks.Add(asset);
        }

        public string StockFileName(long id)
        {
            return "stock"+id.ToString()+".txt";
        }
        public string StockFileName(Stock stock)
        {
            return "stock"+stock.Id.ToString()+".txt";
        }

        public Stock LoadStock(long id)
        {
            return stockio.ReadStock(new FileInfo(StockFileName(id)));
        }

        public void Clear()
        {
            stocks.Clear();
        }        

        ICollection IStockRepository.FindAllStocks()
        {
            return stocks;
        }
    }
}