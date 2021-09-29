using AutoMapper;
using MediatR;
using StocksManagement.Application.Features.StockModule.Commands;
using StocksManagement.Domain.Common.ResultModule;
using StocksManagement.Domain.Features.StockModule;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace StocksManagement.Application.Features.StockModule.Handlers
{
    public class AddStockHandler : IRequestHandler<AddStockCommand, Result<Exception, int>>
    {
        private readonly IStockRepository _stockRepository;
        private readonly IMapper _mapper;

        public AddStockHandler(IStockRepository stockRepository, IMapper mapper)
        {
            _mapper = mapper;
            _stockRepository = stockRepository;
        }

        public Task<Result<Exception, int>> Handle(AddStockCommand addStockCommand, CancellationToken cancellationToken)
        {
            Result<Exception, int> result = Result.Run(() =>
            {
                return _stockRepository.Add(_mapper.Map<Stock>(addStockCommand));
            });

            return Task.FromResult(result);
        }
    }
}
