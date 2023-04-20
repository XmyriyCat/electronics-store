using Data.Repositories.Contracts;
using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.Implementations;

public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    public CategoryRepository(DbContext dbContext) : base(dbContext) 
    {
    }
}