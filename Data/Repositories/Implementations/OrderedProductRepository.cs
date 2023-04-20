using Data.Repositories.Contracts;
using DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories.Implementations
{
    public class OrderedProductRepository : Repository<OrderedProduct>, IOrderedProductRepository
    {
        public OrderedProductRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}