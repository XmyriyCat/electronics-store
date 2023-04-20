using Data.Repositories.Contracts;
using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.Implementations
{
    public class ShipmentRepository : Repository<Shipment>, IShipmentRepository
    {
        public ShipmentRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
