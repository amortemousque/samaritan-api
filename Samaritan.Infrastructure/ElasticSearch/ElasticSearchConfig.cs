using AutoMapper;
using Nest;
using Samaritan.Domain.OrderModule.Models;

namespace Samaritan.Infrastructure.ElasticSearch
{
    public class ElasticSearchConfig
    {
        public static void RegisterMappings(ElasticClient client)
        {
            var response = client.IndexExists(new IndexExistsRequest("order"));
            if(!response.Exists){
                var reponse = client.CreateIndexAsync("order", c => c
                .Mappings(ms => ms
                    .Map<Order>(m => m.AutoMap())
                )
                );
            }
        }
    }
}