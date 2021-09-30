using StocksManagement.Domain.Features.StockModule;
using System.Collections.Generic;

namespace StockManagement.Infra.EF.Features.StockModule
{
    public class StockRepository : IStockRepository
    {
        private static List<Stock> _repository = new List<Stock>
            {
                new Stock
                {
                     Id = 1,
                     Name = "Vale ON",
                     Code = "VALE3",
                     CurrentValue = 89.5m
                },
                new Stock
                {
                     Id = 2,
                     Name = "Petrobras ON",
                     Code = "PETR3",
                     CurrentValue = 25.6m
                }
            };

        public int Add(Stock stockToAdd)
        {
            stockToAdd.Id = _repository.Count + 1;
            _repository.Add(stockToAdd);

            return stockToAdd.Id;
        }

        public Stock Retrive(int stockId)
        {
            return _repository.Find(s => s.Id.Equals(stockId));
        }

        public IEnumerable<Stock> RetriveAll()
        {
            return _repository;
        }
    }
}
