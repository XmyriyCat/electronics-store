using Data.Repositories.Contracts;
using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.Implementations
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
