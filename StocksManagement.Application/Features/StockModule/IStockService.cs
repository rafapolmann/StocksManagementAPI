using StocksManagement.Application.Features.StockModule.Commands;
using StocksManagement.Application.Features.StockModule.Models;
using StocksManagement.Domain.Common.ResultModule;
using System;
using System.Collections.Generic;

namespace StocksManagement.Application.Features.StockModule
{
    public interface IStockService
    {
        Result<Exception, int> Add(AddStockCommand addStockCommand);
        Result<Exception, IEnumerable<StockModel>> Get();
    }
}
