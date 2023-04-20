using System.Linq.Expressions;

namespace Data.Repositories.Contracts
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();

        Task<T> GetByIdAsync(int id);

        Task<T> InsertAsync(T entity);

        T Update(T entity);

        Task DeleteAsync(int id);

        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> expression);
    }
}
