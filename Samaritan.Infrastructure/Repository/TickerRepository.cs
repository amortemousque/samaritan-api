using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nest;
using Newtonsoft.Json;
using Samaritan.Domain.Interface;
using Samaritan.Domain.TickerModule.Models;

namespace Samaritan.Infrastructure.Repository
{
    public class TickerRepository: Repository<Ticker>
    {
        public TickerRepository(ElasticClient client) : base(client)
        {
        }
    }
}