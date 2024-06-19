using Base.Domain.Entities;

namespace Base.Domain.Repositories.Base;

public interface IBaseRepository
{
    Task Add(BaseEntity entity);
}