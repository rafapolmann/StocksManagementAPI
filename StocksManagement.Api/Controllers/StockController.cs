using Microsoft.AspNetCore.Mvc;
using StocksManagement.Api.Base;
using StocksManagement.Application.Features.StockModule;
using StocksManagement.Application.Features.StockModule.Commands;

namespace StocksManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ApiControllerBase
    {
        private readonly IStockService _stockService;
        public StockController(IStockService stockService)
        {
            _stockService = stockService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return HandleResult(_stockService.Get());
        }

        [HttpPost]
        public IActionResult Post([FromBody] AddStockCommand addStockCommand)
        {
            return HandleResult(_stockService.Add(addStockCommand));
        }
    }
}
