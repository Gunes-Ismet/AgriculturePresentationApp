using AgriculturePresentationApp.Entities.Entities.Abstract;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq.Expressions;

namespace AgriculturePresentationApp.Business.Services.Interfaces
{
    public interface IGenericService<Entity, DTO, CreateDTO, UpdateDTO, VM> where Entity : BaseEntity where DTO : class where CreateDTO : class where UpdateDTO : class where VM : class 
    {
        Task CreateAsync(CreateDTO dto);
        Task RemoveAsync(int id);
        Task UpdateAsync(UpdateDTO dto);
        Task<Entity> GetByIdAsync(int id);
        Task<IEnumerable<VM>> GetAllListAsync();
        int Count();
        Task<bool> AnyAsync(Expression<Func<Entity, bool>> expression);

        Task<List<VM>> GetFilteredListAsync(Expression<Func<Entity, VM>> select,
                                                          Expression<Func<Entity, bool>> where = null,
                                                          Func<IQueryable<Entity>, IOrderedQueryable<Entity>> orderBy = null,
                                                          Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> join = null);
    }
}
