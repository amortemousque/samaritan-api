using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nest;
using Newtonsoft.Json;
using Samaritan.Domain.Interface;
using Samaritan.Domain.TradeModule.Models;

namespace Samaritan.Infrastructure.Repository
{
    public class TradeRepository: Repository<Trade>
    {

        public TradeRepository(ElasticClient client) : base(client)
        {
          
        }

        public async Task<List<Trade>> GetTrades()
        {
            return await this.GetAll(0);
        }

  
        
    }
}