using AgriculturePresentationApp.Entities.DTO_s.SocialMediaDTO_s;
using AgriculturePresentationApp.Entities.Entities.Concrete;
using AgriculturePresentationApp.Entities.Models.ViewModels;

namespace AgriculturePresentationApp.Business.Services.Interfaces
{
	public interface ISocialMediaService : IGenericService<SocialMedia,SocialMediaDTO,CreateSocialMediaDTO,UpdateSocialMediaDTO,GetSocialMediaVM>
	{
	}
}
