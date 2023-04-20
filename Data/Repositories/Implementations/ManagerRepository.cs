using Data.Repositories.Contracts;
using DomainModels;
using Microsoft.EntityFrameworkCore;
namespace Data.Repositories.Implementations
{
    public class ManagerRepository : Repository<Manager>, IManagerRepository
    {
        public ManagerRepository(DbContext dbContext) : base(dbContext) 
        {
        }
    }
}
