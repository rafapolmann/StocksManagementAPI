using StocksManagement.Application.Features.StockModule.Commands;
using StocksManagement.Application.Features.StockModule.Models;
using StocksManagement.Domain.Features.StockModule;
using System;
using System.Collections.Generic;

namespace StocksManagement.Application.Features.StockModule
{
    public class StockService : IStockService
    {
        private readonly IStockRepository _stockRepository;
        public StockService(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }

        public int Add(AddStockCommand addStockCommand)
        {
            return _stockRepository.Add(ParseAddStockCommand(addStockCommand));
        }

        public IEnumerable<StockModel> Get()
        {
            return ParseStocks(_stockRepository.RetriveAll());
        }

        private Stock ParseAddStockCommand(AddStockCommand addStockCommand)
        {
            return new Stock
            {
                Name = addStockCommand.Name,
                Code = addStockCommand.Code,
                CurrentValue = addStockCommand.CurrentValue
            };
        }

        private IEnumerable<StockModel> ParseStocks(IEnumerable<Stock> stocksOnRepository)
        {
            List<StockModel> stocks = new();

            foreach (Stock stockInRepository in stocksOnRepository)
                stocks.Add(ParseStock(stockInRepository));

            return stocks;
        }

        private StockModel ParseStock(Stock stockInRepository)
        {
            return new StockModel
            {
                Id = stockInRepository.Id,
                Name = stockInRepository.Name,
                Code = stockInRepository.Code,
                CurrentValue = stockInRepository.CurrentValue
            };
        }
    }
}
