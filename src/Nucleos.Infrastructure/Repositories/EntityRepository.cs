using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Nucleos.Domain.Entities;
using Nucleos.Infrastructure.Context;
using Nucleos.Infrastructure.Interfaces;

namespace Nucleos.Infrastructure.Repositories;

public class EntityRepository<T> : IEntityRepository<T> where T : Entity
{
    private readonly ManagerContext _context;
    
    public EntityRepository(ManagerContext context)
    {
        _context = context;
    }

    public virtual async Task<T> CreateAsync(T obj)
    {
        _context.Add(obj);
        await _context.SaveChangesAsync();

        return obj;
    }

    public virtual async Task<T> UpdateAsync(T obj)
    {
        _context.Entry(obj).State = EntityState.Modified;
        await _context.SaveChangesAsync();

        return obj;
    }

    public virtual async Task<T> DeleteAsync(Guid id)
    {
        var obj = await GetAsync(id);

        if(obj != null){
            _context.Remove(obj);
            await _context.SaveChangesAsync();
        }

        return null;
    }

    public virtual async Task<T> GetAsync(Guid id)
    {
        var obj = await _context.Set<T>()
            .AsNoTracking()
            .Where(x=>x.Id == id)
            .ToListAsync();

        return obj.FirstOrDefault();
    }
    
    
    public virtual async Task<List<T>> GetAllAsync()
    {
        return await _context.Set<T>()
            .AsNoTracking()
            .ToListAsync();
    }

    public virtual async Task<T> GetAsync(
        Expression<Func<T, bool>> expression,
        bool asNoTracking = true)
        => asNoTracking
            ? await BuildQuery(expression)
                .AsNoTracking()
                .FirstOrDefaultAsync()

            : await BuildQuery(expression)
                .AsNoTracking()
                .FirstOrDefaultAsync();

    public virtual async Task<IList<T>> SearchAsync(
        Expression<Func<T, bool>> expression,
        bool asNoTracking = true)
        => asNoTracking
            ? await BuildQuery(expression)
                .AsNoTracking()
                .ToListAsync()

            : await BuildQuery(expression)
                .AsNoTracking()
                .ToListAsync();

    private IQueryable<T> BuildQuery(Expression<Func<T, bool>> expression)
        => _context.Set<T>().Where(expression);
}
