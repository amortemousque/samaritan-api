using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Samaritan.Domain.Interface
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        Task<TEntity> GetById(Guid id);
        Task<List<TEntity>> GetAll(int offset, int? limit = null, string fields = null, object query = null);
        void Update(TEntity obj);
        void Remove(Guid id);
    }
}