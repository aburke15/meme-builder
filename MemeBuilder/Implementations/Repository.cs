using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MemeBuilder.Interfaces;
using MemeBuilder.Models;
using Microsoft.EntityFrameworkCore;

namespace MemeBuilder.Implementations
{
    public class Repository<T> : UnitOfWorkFilter, IRepository<T> where T : class
    {
        private readonly MemeBuilderContext MemeBuilderContext;

        public Repository(MemeBuilderContext memeBuilderContext)
            : base(memeBuilderContext)
        {
            MemeBuilderContext = memeBuilderContext;
        }

        public void Add(T entity) 
            => MemeBuilderContext.Set<T>().Add(entity);

        public async Task AddAsync(T entity) 
            => await MemeBuilderContext.Set<T>().AddAsync(entity);

        public IEnumerable<T> Get() 
            => MemeBuilderContext.Set<T>().ToList();

        public async Task<IEnumerable<T>> GetAsync() 
            => await MemeBuilderContext.Set<T>().ToListAsync();

        public T GetById(Guid id) 
            => MemeBuilderContext.Set<T>().Find(id);

        public async Task<T> GetByIdAsync(Guid id) 
            => await MemeBuilderContext.Set<T>().FindAsync(id);

        public void Remove(Guid id)
        {
            var type = MemeBuilderContext.Set<T>().Find(id);

            if (type is null)
            {
                throw new InvalidOperationException(
                    "Error, cannot delete a non existing entity."
                );
            } 

            MemeBuilderContext.Remove(type);
        }

        public async Task RemoveAsync(Guid id)
        {
            var type = await MemeBuilderContext.Set<T>().FindAsync(id);

            if (type is null)
            {
                throw new InvalidOperationException(
                    "Error, cannot delete a non existing entity."
                );
            }
            
            MemeBuilderContext.Remove(type);
        }

        public void Save(T entity) 
            => MemeBuilderContext.SaveChanges();

        public async Task SaveAsync(T entity)
            => await MemeBuilderContext.SaveChangesAsync();

        public void Update(T entity) 
            => MemeBuilderContext.Set<T>().Attach(entity);
    }
}