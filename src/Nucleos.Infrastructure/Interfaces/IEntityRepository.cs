using System.Linq.Expressions;
using Nucleos.Domain.Entities;

namespace Nucleos.Infrastructure.Interfaces;

public interface IEntityRepository<T> where T : Entity
{
    Task<T> CreateAsync(T obj);
    Task<T> UpdateAsync(T obj);
    Task<T> DeleteAsync(Guid id);
    Task<T> GetAsync(Guid id);
    Task<T> GetAsync(Expression<Func<T, bool>> expression, bool asNoTracking = true);
    Task<List<T>> GetAllAsync();
    Task<IList<T>> SearchAsync(Expression<Func<T, bool>> expression, bool asNoTracking = true);
}