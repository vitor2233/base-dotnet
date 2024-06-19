
namespace Base.Domain.Repositories;
public interface IUnitOfWork
{
    Task Commit();
}