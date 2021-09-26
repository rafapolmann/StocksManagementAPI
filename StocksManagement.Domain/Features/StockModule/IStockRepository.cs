using System.Collections.Generic;

namespace StocksManagement.Domain.Features.StockModule
{
    public interface IStockRepository
    {
        int Add(Stock stockToAdd);
        IEnumerable<Stock> RetriveAll();
    }
}
