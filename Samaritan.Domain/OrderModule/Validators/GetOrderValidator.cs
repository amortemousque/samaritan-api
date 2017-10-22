using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using Samaritan.Domain.OrderModule.Queries;
using Samaritan.Domain.OrderModule.Models;

namespace Samaritan.Domain.OrderModule.Validators
{
    public class GetOrderValidator : AbstractValidator<GetOrderQuery>
    {
        public GetOrderValidator()
        {
            RuleFor(o => o.OrderId).NotEmpty().WithMessage("Name is required.");
        }
    }
}
