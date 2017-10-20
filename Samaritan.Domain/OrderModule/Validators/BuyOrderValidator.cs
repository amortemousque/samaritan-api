using FluentValidation;
using Samaritan.Domain.OrderModule.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Samaritan.Domain.OrderModule.Validators
{
    public class BuyOrderValidator : AbstractValidator<BuyOrderCommand>
    {
        public BuyOrderValidator()
        {
            RuleFor(o => o.OrderId).NotEmpty().WithMessage("Name is required.");
        }
    }
}
