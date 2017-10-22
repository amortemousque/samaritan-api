using System.Threading.Tasks;
using FluentValidation;
using Samaritan.Domain.TickerModule.Models;
using Samaritan.Domain.TickerModule.Queries;
using Samaritan.Domain.TickerModule.Validators;

namespace Samaritan.Domain.TickerModule.CommandHandlers 
{
    public class TickerHandler {


        public async Task<Ticker> Handle(GetTickerQuery message, 
        AbstractValidator<GetTickerQuery> validator) {
            var result = await validator.ValidateAsync(message);
            
            return result.IsValid ? new Ticker() : null;
        }

    }
}