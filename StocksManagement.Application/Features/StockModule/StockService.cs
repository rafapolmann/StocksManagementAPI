using AutoMapper;
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
        private readonly IMapper _mapper;
        public StockService(IStockRepository stockRepository, IMapper mapper)
        {
            _stockRepository = stockRepository;
            _mapper = mapper;
        }

        public int Add(AddStockCommand addStockCommand)
        {
            return _stockRepository.Add(_mapper.Map<Stock>(addStockCommand));
        }

        public IEnumerable<StockModel> Get()
        {
            return _mapper.Map<IEnumerable<StockModel>>(_stockRepository.RetriveAll());
        }
    }
}
