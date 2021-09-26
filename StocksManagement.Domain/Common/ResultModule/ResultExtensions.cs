using System;
namespace StocksManagement.Domain.Common.ResultModule
{
    using static Helpers;
    public static class Result
    {
        public static Result<Exception, TSuccess> Run<TSuccess>(this Func<TSuccess> func)
        {
            try
            {
                return func();
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        public static Result<Exception, Unit> Run(this Action action) => Run(ToFunc(action));
        public static Result<Exception, TSuccess> Run<TSuccess>(this Exception ex) => ex;
    }
}
