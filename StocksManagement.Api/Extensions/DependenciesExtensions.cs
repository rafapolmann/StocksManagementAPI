using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StockManagement.Infra.EF.Features.StockModule;
using StocksManagement.Application.Features.StockModule;
using StocksManagement.Domain.Features.StockModule;

namespace StocksManagement.Api.Extensions
{
    public static class DependenciesExtensions
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IStockService, StockService>();
            services.AddScoped<IStockRepository, StockRepository>();
        }
    }
}
