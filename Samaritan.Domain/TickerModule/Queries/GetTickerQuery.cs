using MediatR;
using Samaritan.Domain.TickerModule.Models;

namespace Samaritan.Domain.TickerModule.Queries {
    public class GetTickerQuery: IRequest<Ticker> {
        public long TickerId { get; set; }
    }
}