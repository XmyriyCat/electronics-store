using Data.Repositories.Contracts;
using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.Implementations
{
    public class PictureProductRepository : Repository<PictureProduct>, IPictureProductRepository
    {
        public PictureProductRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
