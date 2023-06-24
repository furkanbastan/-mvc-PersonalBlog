using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace PersonalBlog.Data.Repositories;

public interface IRepository<T>
{
    public Task<List<T>> GetAllAsync(Expression<Func<T,bool>> predicate=null, params Expression<Func<T,object>>[] includeProperties);
    public Task<List<T>> GetAsync(Expression<Func<T, bool>> predicate , params Expression<Func<T,object>>[] includeProperties);
    public Task AddAsync(T entity);
    public Task AddRangeAsync(List<T> entity);
    public Task AnyAsync(Expression<Func<T,bool>> predicate);
    public Task<int> CountAsync(Expression<Func<T,bool>> predicate = null);
    public Task DeleteAsync(T entity);
    public Task<T> GetByGuidAsync(Guid id);
    public Task UpdateAsync(T entity);
    public Task<int> SaveAsync();
}
