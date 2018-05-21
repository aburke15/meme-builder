using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemeBuilderData.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace MemeBuilderData.Implementations
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly MemeBuilderContext MemeBuilderContext;

        public Repository(MemeBuilderContext memeBuilderContext) 
            => MemeBuilderContext = memeBuilderContext;

        public void Add(T entity) 
            => MemeBuilderContext.Set<T>().Add(entity);

        public async Task AddAsync(T entity) 
            => await MemeBuilderContext.Set<T>().AddAsync(entity);

        public IEnumerable<T> Get() 
            => MemeBuilderContext.Set<T>().ToList();

        public async Task<IEnumerable<T>> GetAsync()
        {
            return await MemeBuilderContext.Set<T>().ToListAsync();
        }

        public T GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Save(T entity)
        {
            throw new NotImplementedException();
        }

        public Task SaveAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}