using Base.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Base.Infra.DataAccess;
internal class BaseDbContext : DbContext
{
    public BaseDbContext(DbContextOptions options) : base(options) { }
    public DbSet<BaseEntity> Bases { get; set; }
}
