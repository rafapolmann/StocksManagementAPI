using MediatR;
using StocksManagement.Application.Features.StockModule.Models;
using StocksManagement.Domain.Common.ResultModule;
using System;
using System.Collections.Generic;

namespace StocksManagement.Application.Features.StockModule.Queries
{
    public class AllStockQuery : IRequest<Result<Exception, List<StockModel>>>
    {
    }
}
