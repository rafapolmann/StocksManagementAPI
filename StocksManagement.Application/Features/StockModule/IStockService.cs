using StocksManagement.Application.Features.StockModule.Commands;
using StocksManagement.Application.Features.StockModule.Models;
using System.Collections.Generic;

namespace StocksManagement.Application.Features.StockModule
{
    public interface IStockService
    {
        bool Add(AddStockCommand addStockCommand);
        IEnumerable<StockModel> Get();
    }
}
