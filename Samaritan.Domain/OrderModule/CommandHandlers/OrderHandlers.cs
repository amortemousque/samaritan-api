using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Samaritan.Domain.OrderModule.Commands
{
    public class OrderHandlers :
    IAsyncRequestHandler<BuyOrderCommand, bool>,
    IAsyncRequestHandler<SellOrderCommand, bool>
    {
        public async Task<bool> Handle(BuyOrderCommand message)
        {

            return true;
        }

        public async Task<bool> Handle(SellOrderCommand message)
        {
            return true;
        }
    }
}
