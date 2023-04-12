using Data.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Contracts
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected DbContext context;
        protected DbSet<T> table;

        protected Repository(DbContext context)
        {
            this.context = context ?? throw new ArgumentNullException(nameof(context));
            this.table = context.Set<T>() ?? throw new ArgumentNullException(nameof(context));
        }

        public async virtual Task AsyncDelete(int id)
        {
            T entity = await table.FindAsync(id) ?? throw new NoSuchEntityFoundException();
            table.Remove(entity);
        }

        public async virtual Task<IEnumerable<T>> AsyncGetAll()
        {
            return await table.ToArrayAsync();
        }

        public async virtual Task<T> AsyncGetById(int id)
        {
            return await table.FindAsync(id) ?? throw new NoSuchEntityFoundException();
        }

        public async virtual Task<T> AsyncInsert(T entity)
        {
            await table.AddAsync(entity);
            return entity;
        }

        public async virtual Task AsyncSave()
        {
            await context.SaveChangesAsync();
        }

        public virtual T Update(T entity)
        {
            // TODO: This part should be refactored.

            table.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
            return entity;
        }
    }
}
