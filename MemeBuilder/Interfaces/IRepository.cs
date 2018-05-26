using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MemeBuilder.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);

        Task AddAsync(T entity);

        IEnumerable<T> Get();

        Task<IEnumerable<T>> GetAsync();

        T GetById(Guid id);

        Task<T> GetByIdAsync(Guid id);

        void Remove(Guid id);

        Task RemoveAsync(Guid id);

        void Save(T entity);

        Task SaveAsync(T entity);

        void Update(T entity);
    }
}