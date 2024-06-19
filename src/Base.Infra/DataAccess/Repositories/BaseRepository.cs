
using Base.Domain.Entities;
using Base.Domain.Repositories.Base;
using Base.Infra.DataAccess;

namespace Base.Infra.Repositories;

internal class BaseRepository : IBaseRepository
{
    private readonly BaseDbContext _context;

    public BaseRepository(BaseDbContext context)
    {
        _context = context;
    }

    public async Task Add(BaseEntity entity)
    {
        await _context.Bases.AddAsync(entity);
    }
}