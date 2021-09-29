using FluentValidation;
using MediatR;
using StocksManagement.Domain.Common.ResultModule;
using System;

namespace StocksManagement.Application.Features.StockModule.Commands
{
    public class AddStockCommand : IRequest<Result<Exception, int>>
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal CurrentValue { get; set; }
    }

    public class StockValidator : AbstractValidator<AddStockCommand>
    {
        public StockValidator()
        {
            RuleFor(s => s.Name).NotEmpty().WithMessage("Name cannot be empty.");
            RuleFor(s => s.Code).Length(5);
            RuleFor(s => s.CurrentValue).GreaterThan(0);
        }
    }
}
