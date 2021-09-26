using Microsoft.AspNetCore.Mvc;
using StocksManagement.Domain.Common.ResultModule;
using System.Net;

namespace StocksManagement.Api.Base
{
    public class ApiControllerBase : Controller
    {
        public IActionResult HandleResult<TFailure, TSuccess>(Result<TFailure, TSuccess> callback)
        {
            return callback.IsSuccess ? Ok(callback.Success) : StatusCode(HttpStatusCode.InternalServerError.GetHashCode(), callback.Failure);
        }
    }
}
