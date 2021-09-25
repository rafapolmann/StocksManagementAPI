using Microsoft.AspNetCore.Mvc;
using StocksManagement.Domain.Features.StockModule;
using StocksManagement.Domain.Features.StockModule.Interfaces;
using System.Collections.Generic;

namespace StocksManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ControllerBase
    {
        private readonly IStockService _stockService;
        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet]
        public IEnumerable<Stock> Get()
        {
            return _stockService.Get();
        }
    }
}
