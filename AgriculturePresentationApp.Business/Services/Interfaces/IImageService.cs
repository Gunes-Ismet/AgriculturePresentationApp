using AgriculturePresentationApp.Entities.DTO_s.ImageDTO_s;
using AgriculturePresentationApp.Entities.Entities.Concrete;
using AgriculturePresentationApp.Entities.Models.ViewModels;

namespace AgriculturePresentationApp.Business.Services.Interfaces
{
    public interface IImageService : IGenericService<Image, ImageDTO, CreateImageDTO, UpdateImageDTO, GetImageVM>
    {
        Task UpdateAsync(UpdateImageDTO model);

        Task CreateAsync(CreateImageDTO model);

        Task RemoveAsync(int id);
    }
}
