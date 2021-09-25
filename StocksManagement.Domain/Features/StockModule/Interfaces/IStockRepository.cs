using System.Collections.Generic;

namespace StocksManagement.Domain.Features.StockModule.Interfaces
{
    public interface IStockRepository
    {
        IEnumerable<Stock> RetriveAll();
    }
}
