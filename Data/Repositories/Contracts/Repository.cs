using System.Linq.Expressions;
using Data.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.Contracts
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected readonly DbContext Context;
        
        protected readonly DbSet<T> Table;

        protected Repository(DbContext context)
        {
            Context = context ?? throw new ArgumentNullException(nameof(context));
            Table = context.Set<T>();
        }
        
        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            var entities = await Table
                .AsNoTracking()
                .ToArrayAsync();

            return entities;
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await Table.FindAsync(id) ?? throw new NoSuchEntityFoundException();
        }

        public virtual async Task<T> InsertAsync(T entity)
        {
            await Table.AddAsync(entity);
            return entity;
        }

        public virtual T Update(T entity)
        {
            var updatingResult = Table.Update(entity);

            return updatingResult.Entity;
        }
        
        public virtual async Task DeleteAsync(int id)
        {
            var entity = await Table.FindAsync(id) ?? throw new NoSuchEntityFoundException();
            Table.Remove(entity);
        }

        public virtual async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> expression)
        {
            var entity = await Table.FirstOrDefaultAsync(expression);

            return entity;
        }
    }
}