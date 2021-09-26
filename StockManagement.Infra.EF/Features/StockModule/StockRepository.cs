using StocksManagement.Domain.Features.StockModule;
using System.Collections.Generic;

namespace StockManagement.Infra.EF.Features.StockModule
{
    public class StockRepository : IStockRepository
    {
        public IEnumerable<Stock> RetriveAll()
        {
            return new List<Stock>
            {
                new Stock
                {
                     Name = "Vale ON",
                     Code = "VALE3",
                     CurrentValue = 89.5m
                },
                new Stock
                {
                     Name = "Petrobras ON",
                     Code = "PETR3",
                     CurrentValue = 25.6m
                }
            };
        }
    }
}
