using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace StocksManagement.Api.Extensions
{
    public static class CorsExtensions
    {
        private const string STOCK_MANAGEMENT_CORS_POLICY = "StockManagementCorsPolicy";

        public static void AddCorsPolicy(this IServiceCollection services)
        {
            services.AddCors(option =>
            {
                option.AddPolicy(STOCK_MANAGEMENT_CORS_POLICY, builder =>
                 {
                     builder.AllowAnyOrigin()
                            .AllowAnyMethod()
                            .AllowAnyHeader();
                 });
            });
        }

        public static void UseCorsPolicy(this IApplicationBuilder app)
        {
            app.UseCors(STOCK_MANAGEMENT_CORS_POLICY);
        }
    }
}
