
using Base.Domain.Repositories;
using Base.Infra.DataAccess;

namespace Base.Infra.DataAccess;

internal class UnitOfWork : IUnitOfWork
{
    private readonly BaseDbContext _dbContext;
    public UnitOfWork(BaseDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task Commit() => await _dbContext.SaveChangesAsync();
}