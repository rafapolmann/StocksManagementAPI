using FluentValidation.AspNetCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using StockManagement.Infra.EF.Features.StockModule;
using StocksManagement.Api.Filters;
using StocksManagement.Application;
using StocksManagement.Application.Features.StockModule;
using StocksManagement.Domain.Features.StockModule;
using System.Reflection;

namespace StocksManagement.Api.Extensions
{
    public static class DependenciesExtensions
    {
        public static void AddDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IStockService, StockService>();
            services.AddScoped<IStockRepository, StockRepository>();

            Assembly applicationAssembly = typeof(AppModule).Assembly;
            services.AddControllers(opt =>
            {
                opt.Filters.Add(typeof(ValidatorActionFilter));
            }).AddFluentValidation(fv => fv.RegisterValidatorsFromAssembly(applicationAssembly));

            services.AddAutoMapper(applicationAssembly);
        }
    }
}
