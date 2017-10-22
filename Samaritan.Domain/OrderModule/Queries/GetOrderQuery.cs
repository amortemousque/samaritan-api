using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Samaritan.Domain.OrderModule.Models;

namespace Samaritan.Domain.OrderModule.Queries
{
    public class GetOrderQuery: IRequest<Order>
    {
        public long OrderId { get; set; }
    }
}
