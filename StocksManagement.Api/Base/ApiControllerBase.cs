using Microsoft.AspNetCore.Mvc;
using StocksManagement.Api.Exceptions;
using StocksManagement.Domain.Common.ResultModule;
using System;
using System.Net;

namespace StocksManagement.Api.Base
{
    public class ApiControllerBase : Controller
    {
        public IActionResult HandleResult<TFailure, TSuccess>(Result<TFailure, TSuccess> callback) where TFailure : Exception
        {
            return callback.IsSuccess ? Ok(callback.Success) : HandleFailure(callback.Failure);
        }

        public IActionResult HandleFailure<T>(T exceptionHandle) where T : Exception
        {
            return StatusCode(HttpStatusCode.InternalServerError.GetHashCode(), ExceptionPayload.New(exceptionHandle));
        }
    }
}
