using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Samaritan.Domain.TradeModule.Queries;
using Samaritan.Domain.TradeModule.Models;

namespace Samaritan.Domain.TradeModule.Validators
{
    public class GetTradeValidator : AbstractValidator<GetTradeQuery>
    {
        public GetTradeValidator()
        {
            RuleFor(o => o.TradeId).NotEmpty().WithMessage("Trade id is required.");
        }
    }
}
