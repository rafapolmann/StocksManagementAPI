using MediatR;
using StocksManagement.Application.Features.StockModule.Models;
using StocksManagement.Domain.Common.ResultModule;
using System;

namespace StocksManagement.Application.Features.StockModule.Queries
{
    public class StockIdQuery : IRequest<Result<Exception, StockModel>>
    {
        public int StockId { get; set; }

        public StockIdQuery(int sotckId)
        {
            StockId = sotckId;
        }
    }
}
