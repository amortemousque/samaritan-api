using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nest;
using Newtonsoft.Json;
using Samaritan.Domain.Interface;
using Samaritan.Domain.OrderModule.Models;

namespace Samaritan.Infrastructure.Repository
{
    public class OrderRepository: Repository<Order>
    {
        public OrderRepository(ElasticClient client) : base(client)
        {
        }
    }
}