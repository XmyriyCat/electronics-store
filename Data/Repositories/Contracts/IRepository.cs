using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Contracts
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> AsyncGetAll();

        Task<T> AsyncGetById(int id);

        Task<T> AsyncInsert(T entity);

        T Update(T entity);

        Task AsyncDelete(int id);

        Task AsyncSave();
    }
}
