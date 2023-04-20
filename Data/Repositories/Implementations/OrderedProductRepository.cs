using Data.Repositories.Contracts;
using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.Implementations
{
    public class OrderedProductRepository : Repository<OrderedProduct>, IOrderedProductRepository
    {
        public OrderedProductRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}