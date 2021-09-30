using AutoMapper;
using MediatR;
using StocksManagement.Application.Features.StockModule.Models;
using StocksManagement.Application.Features.StockModule.Queries;
using StocksManagement.Domain.Common.ResultModule;
using StocksManagement.Domain.Features.StockModule;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace StocksManagement.Application.Features.StockModule.Handlers
{
    public class GetStockHandler : IRequestHandler<StockIdQuery, Result<Exception, StockModel>>
    {
        private readonly IStockRepository _stockRepository;
        private readonly IMapper _mapper;

        public GetStockHandler(IStockRepository stockRepository, IMapper mapper)
        {
            _stockRepository = stockRepository;
            _mapper = mapper;
        }

        public Task<Result<Exception, StockModel>> Handle(StockIdQuery request, CancellationToken cancellationToken)
        {
            Result<Exception, StockModel> result = Result.Run(() =>
            {
                Stock stockFromDb = _stockRepository.Retrive(request.StockId);
                if (stockFromDb == null)
                    throw new Exception("obj not found");

                return _mapper.Map<StockModel>(stockFromDb);
            });

            return Task.FromResult(result);
        }
    }
}
