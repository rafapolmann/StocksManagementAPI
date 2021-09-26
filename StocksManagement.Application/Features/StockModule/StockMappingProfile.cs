using AutoMapper;
using StocksManagement.Application.Features.StockModule.Commands;
using StocksManagement.Application.Features.StockModule.Models;
using StocksManagement.Domain.Features.StockModule;

namespace StocksManagement.Application.Features.StockModule
{
    public class StockMappingProfile : Profile
    {
        public StockMappingProfile()
        {
            CreateMap<Stock, StockModel>();
            CreateMap<AddStockCommand, Stock>();
        }
    }
}
