using AgriculturePresentationApp.Entities.Entities.Abstract;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace AgriculturePresentationApp.DataAccess.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task CreateAsync(T entity);
        void Remove(T entity);
        void Update(T entity);
        Task<T> GetByIdAsync(int id);
        IQueryable<T> GetAllList();
        int Count();
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);

        Task<List<TResult>> GetFilteredListAsync<TResult>(Expression<Func<T, TResult>> select,
                                                          Expression<Func<T, bool>> where = null,
                                                          Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null,
                                                          Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null);
    }
}
