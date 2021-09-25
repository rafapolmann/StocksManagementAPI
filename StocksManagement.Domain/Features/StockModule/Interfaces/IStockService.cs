using System.Collections.Generic;

namespace StocksManagement.Domain.Features.StockModule.Interfaces
{
    public interface IStockService
    {
        IEnumerable<Stock> Get();
    }
}
