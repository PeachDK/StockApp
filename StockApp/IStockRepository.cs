using System.Collections;

namespace StockApp
{
    internal interface IStockRepository
    {
        long NextId();
        void SaveStock(Stock yhoo);
        Stock LoadStock(long id);
        void Clear();
        ICollection FindAllStocks();
    }
}