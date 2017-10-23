using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Samaritan.Domain.TradeModule.Models;

namespace Samaritan.Domain.TradeModule.Queries
{
    public class GetTradeQuery: IRequest<Trade>
    {
        public long TradeId { get; set; }
    }
}
