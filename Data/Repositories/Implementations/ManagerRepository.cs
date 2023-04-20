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
    public class ManagerRepository : Repository<Manager>, IManagerRepository
    {
        public ManagerRepository(DbContext dbContext) : base(dbContext) 
        {
        }
    }
}
