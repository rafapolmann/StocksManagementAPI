using System.Collections.Generic;

namespace StocksManagement.Domain.Features.StockModule
{
    public interface IStockRepository
    {
        IEnumerable<Stock> RetriveAll();
    }
}
