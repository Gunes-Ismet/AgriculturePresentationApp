using AgriculturePresentationApp.DataAccess.Contexts;
using AgriculturePresentationApp.DataAccess.Repositories.Interfaces;
using AgriculturePresentationApp.Entities.Entities.Abstract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace AgriculturePresentationApp.DataAccess.Repositories.Concretes
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly AgriculturePresentationAppDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AgriculturePresentationAppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await _dbSet.AnyAsync(expression);
        }

        public int Count()
        {
           return _dbSet.Count();
        }

        public async Task CreateAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }
        public IQueryable<T> GetAllList()
        {
            return _dbSet.AsNoTracking().AsQueryable();
        }
        public async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<List<TResult>> GetFilteredListAsync<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, bool>> where = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, Func<IQueryable<T>, IIncludableQueryable<T, object>> join = null)
        {
            IQueryable<T> query = _dbSet;
            if (join != null)
            {
                query = join(query);
            }

            if (where != null)
            {
                query = query.Where(where);
            }

            if (orderBy != null)
            {
                var values = await orderBy(query).Select(select).ToListAsync();
                return values;
            }

            else
            {
                var values = await query.Select(select).ToListAsync();
                return values;
            }
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }
        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
