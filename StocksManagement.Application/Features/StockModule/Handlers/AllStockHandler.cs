using AutoMapper;
using MediatR;
using StocksManagement.Application.Features.StockModule.Models;
using StocksManagement.Application.Features.StockModule.Queries;
using StocksManagement.Domain.Common.ResultModule;
using StocksManagement.Domain.Features.StockModule;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace StocksManagement.Application.Features.StockModule.Handlers
{
    public class AllStockHandler : IRequestHandler<AllStockQuery, Result<Exception, List<StockModel>>>
    {
        private readonly IStockRepository _stockRepository;
        private readonly IMapper _mapper;
        public AllStockHandler(IStockRepository stockRepository, IMapper mapper)
        {
            _mapper = mapper;
            _stockRepository = stockRepository;
        }

        public Task<Result<Exception, List<StockModel>>> Handle(AllStockQuery request, CancellationToken cancellationToken)
        {
            Result<Exception, List<StockModel>> result = Result.Run(() =>
            {
               return _mapper.Map<List<StockModel>>(_stockRepository.RetriveAll());
            });

            return Task.FromResult(result);
        }
    }
}
