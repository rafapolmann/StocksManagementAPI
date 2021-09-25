using StocksManagement.Domain.Features.StockModule;
using StocksManagement.Domain.Features.StockModule.Interfaces;
using System.Collections.Generic;

namespace StocksManagement.Application
{
    public class StockService : IStockService
    {
        private readonly IStockRepository _stockRepository;
        public StockService(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        public IEnumerable<Stock> Get()
        {
            return _stockRepository.RetriveAll();            
        }
    }
}
