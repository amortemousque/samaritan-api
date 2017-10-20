using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Samaritan.Domain.OrderModule.Commands
{
    public class SellOrderCommand : IRequest<bool>
    {
        public long OrderId { get; set; }
    }
}
