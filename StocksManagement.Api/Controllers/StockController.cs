using MediatR;
using Microsoft.AspNetCore.Mvc;
using StocksManagement.Api.Base;
using StocksManagement.Application.Features.StockModule.Commands;
using StocksManagement.Application.Features.StockModule.Queries;
using System.Threading.Tasks;

namespace StocksManagement.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : ApiControllerBase
    {
        private readonly IMediator _mediator;
        public StockController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<StockController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return HandleResult(await _mediator.Send(new AllStockQuery()));
        }

        // GET api/<StockController>/5
        //[HttpGet("{id}")]
        //public IActionResult Get(int id)
        //{
        //    return HandleResult(_stockService.Get(id));
        //}

        // POST api/<StockController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] AddStockCommand addStockCommand)
        {
            return HandleResult(await _mediator.Send(addStockCommand));
        }
    }
}
