using FluentValidation;
using Samaritan.Domain.TickerModule.Queries;

namespace Samaritan.Domain.TickerModule.Validators {

    public class GetTickerValidator: AbstractValidator<GetTickerQuery> {
        
        public GetTickerValidator() {
            RuleFor(o => o.TickerId).NotEmpty().WithMessage("Ticker Id cannot be empty");
        }

    }

}