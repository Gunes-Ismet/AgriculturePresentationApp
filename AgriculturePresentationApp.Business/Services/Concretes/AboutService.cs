using AgriculturePresentationApp.Business.Services.Interfaces;
using AgriculturePresentationApp.DataAccess.Repositories.Interfaces;
using AgriculturePresentationApp.DataAccess.UnitOfWorks;
using AgriculturePresentationApp.Entities.DTO_s.AboutDTO_s;
using AgriculturePresentationApp.Entities.Entities.Concrete;
using AgriculturePresentationApp.Entities.Models.ViewModels;
using AutoMapper;

namespace AgriculturePresentationApp.Business.Services.Concretes
{
	public class AboutService : GenericService<About, AboutDTO, CreateAboutDTO, UpdateAboutDTO, GetAboutVM>, IAboutService
	{
		public AboutService(IGenericRepository<About> repository, IUnitofWork unitofWork, IMapper mapper) : base(repository, unitofWork, mapper)
		{
		}
	}
}
