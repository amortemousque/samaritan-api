using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Nest;
using Newtonsoft.Json;
using Samaritan.Domain.Interface;

namespace Samaritan.Infrastructure.Repository
{
    public class Repository<TEntity> : Samaritan.Domain.Interface.IRepository<TEntity> where TEntity : class
    {
        protected readonly ElasticClient _client;

        public Repository(ElasticClient client)
        {
            _client = client;
        }

        public void Add(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public async Task<TEntity> GetById(Guid id)
        {
            var response = await _client.GetAsync<TEntity>(id);
            return response.Source;
        }

        public async Task<List<TEntity>> GetAll(int offset, int? limit = null, string fields = null, object query = null)
        {
            var queryString = JsonConvert.SerializeObject(query);
            var rawQuery = new RawQuery() {
                Raw = @queryString
            };
            var searchQuery =  new SearchRequest<TEntity>(){
                From = offset,
                Size = limit,
                Source = new SourceFilter {
                    Includes = fields
                },
                Query = rawQuery
            };
            var result = await _client.SearchAsync<TEntity>(searchQuery);
            return result.Hits.Select(t => t.Source).ToList();
        }

        public void Update(TEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}