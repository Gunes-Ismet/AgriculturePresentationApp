using AgriculturePresentationApp.Business.Services.Interfaces;
using AgriculturePresentationApp.DataAccess.Repositories.Interfaces;
using AgriculturePresentationApp.DataAccess.UnitOfWorks;
using AgriculturePresentationApp.Entities.Entities.Abstract;

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System.Linq;
using System.Linq.Expressions;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace AgriculturePresentationApp.Business.Services.Concretes
{
    public class GenericService<Entity, DTO, CreateDTO, UpdateDTO, VM> : IGenericService<Entity, DTO, CreateDTO, UpdateDTO, VM> where Entity : BaseEntity where CreateDTO : class where UpdateDTO : class where VM : class where DTO : class
    {
        private readonly IGenericRepository<Entity> _repository;
        protected readonly IUnitofWork _unitofWork;
        protected readonly IMapper _mapper;

        public GenericService(IGenericRepository<Entity> repository, IUnitofWork unitofWork, IMapper mapper)
        {
            _repository = repository;
            _unitofWork = unitofWork;
            _mapper = mapper;
        }
        public async Task CreateAsync(CreateDTO dto)
        {
            var entity = _mapper.Map<Entity>(dto);
            await _repository.CreateAsync(entity);
            await _unitofWork.CommitAsync();
        }
        public async Task<IEnumerable<VM>> GetAllListAsync()
        {
            var entities = await _repository.GetAllList().ToListAsync();
            var dtoList = _mapper.Map<IEnumerable<VM>>(entities);
            return dtoList;
        }
        public async Task<Entity> GetByIdAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return entity;
        }
        public async Task RemoveAsync(int id)
        {
            var entity = await _repository.GetByIdAsync(id);
            _repository.Remove(entity);
            await _unitofWork.CommitAsync();
        }
        public async Task UpdateAsync(UpdateDTO dto)
        {
            var entity = _mapper.Map<Entity>(dto);
            _repository.Update(entity);
            await _unitofWork.CommitAsync();
        }
        public Task<bool> AnyAsync(Expression<Func<Entity, bool>> expression)
        {
            return _repository.AnyAsync(expression);
        }

        public async Task<List<VM>> GetFilteredListAsync(Expression<Func<Entity, VM>> select, Expression<Func<Entity, bool>> where = null, Func<IQueryable<Entity>, IOrderedQueryable<Entity>> orderBy = null, Func<IQueryable<Entity>, IIncludableQueryable<Entity, object>> join = null)
        {
            if (join == null && orderBy == null && where == null)
            {
                var values = await _repository.GetFilteredListAsync(select);
                return _mapper.Map<List<VM>>(values);
            }
            if (join == null && orderBy == null)
            {
                var values = await _repository.GetFilteredListAsync(select, where);
                return _mapper.Map<List<VM>>(values);
            }
            if (join == null)
            {
                var values = await _repository.GetFilteredListAsync(select, where, orderBy);
                return _mapper.Map<List<VM>>(values);
            }
            else
            {
                var values = await _repository.GetFilteredListAsync(select, where, orderBy, join);
                return _mapper.Map<List<VM>>(values);
            }
        }

        public int Count()
        {
            return _repository.Count();
        }
    }
}
