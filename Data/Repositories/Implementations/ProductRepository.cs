using Data.Repositories.Contracts;
using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.Implementations
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        public ProductRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
