namespace _11_Files
{
    internal interface IFileRepository : IStockRepository 
    {
        string StockFileName(long id);
        string StockFileName(Stock stock);
        
    }
}