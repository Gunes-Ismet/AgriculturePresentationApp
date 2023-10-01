using AgriculturePresentationApp.Entities.DTO_s.AboutDTO_s;
using AgriculturePresentationApp.Entities.Entities.Concrete;
using AgriculturePresentationApp.Entities.Models.ViewModels;

namespace AgriculturePresentationApp.Business.Services.Interfaces
{
	public interface IAboutService : IGenericService<About, AboutDTO,CreateAboutDTO,UpdateAboutDTO,GetAboutVM>
	{
	}
}
