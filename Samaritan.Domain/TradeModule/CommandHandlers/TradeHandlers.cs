using MediatR;
using Samaritan.Domain.TradeModule.Validators;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Samaritan.Domain.TradeModule.Models;
using Samaritan.Domain.TradeModule.Queries;

namespace Samaritan.Domain.TradeModule.Commands
{
    public class TradeHandlers :
    IAsyncRequestHandler<GetTradeQuery, Trade>
    
    {
        public TradeHandlers() {

        }
      
        public async Task<Trade> Handle(GetTradeQuery message)
        {
            var validator = new GetTradeValidator();
            var result = await validator.ValidateAsync(message);
            if (result.IsValid)
            {
                //todo
                return new Trade();
            }
            //todo
            return new Trade();
        }
    }
}
