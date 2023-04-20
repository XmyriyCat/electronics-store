using Data.Repositories.Contracts;

namespace Data.UnitOfWork;

public interface IRepositoryWrapper
{
    ICategoryRepository Categories { get; }

    Task SaveChangesAsync();
}