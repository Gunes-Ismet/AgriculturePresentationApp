using AgriculturePresentationApp.Business.Services.Interfaces;
using AgriculturePresentationApp.DataAccess.Repositories.Interfaces;
using AgriculturePresentationApp.DataAccess.UnitOfWorks;
using AgriculturePresentationApp.Entities.DTO_s.SocialMediaDTO_s;
using AgriculturePresentationApp.Entities.Entities.Concrete;
using AgriculturePresentationApp.Entities.Models.ViewModels;
using AutoMapper;

namespace AgriculturePresentationApp.Business.Services.Concretes
{
	public class SocialMediaService : GenericService<SocialMedia,SocialMediaDTO,CreateSocialMediaDTO,UpdateSocialMediaDTO,GetSocialMediaVM>, ISocialMediaService
	{
		public SocialMediaService(IGenericRepository<SocialMedia> repository, IUnitofWork unitofWork, IMapper mapper) : base(repository, unitofWork, mapper)
		{
		}
	}
}
