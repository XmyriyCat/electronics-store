using Data.Repositories.Contracts;
using DomainModels;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories.Implementations
{
    public class PaymentWayRepository : Repository<PaymentWay>, IPaymentWayRepository
    {
        public PaymentWayRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
