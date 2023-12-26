using System.Linq.Expressions;
using VillaAPi.Models;

namespace VillaAPi.Repository.IRepository
{
    public interface IRepository<T> where T : class
    {
        Task<List<T>> GetAll(Expression<Func<T, bool>>? filter = null,string? includeProperties = null);
        Task<T> Get(Expression<Func<T, bool>> filter = null, bool tracked = true, string? includeProperties = null);
        Task Create(T entity);
        Task Remove(T entity);
        Task Save();
    }
}
