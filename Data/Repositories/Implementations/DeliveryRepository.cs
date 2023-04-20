using Data.Repositories.Contracts;
using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.Implementations
{
    public class DeliveryRepository : Repository <Delivery>, IDeliveryRepository
    {
        public DeliveryRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
