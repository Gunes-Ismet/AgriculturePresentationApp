using AgriculturePresentationApp.Entities.DTO_s.AdressDTO_s;
using AgriculturePresentationApp.Entities.Entities.Concrete;
using AgriculturePresentationApp.Entities.Models.ViewModels;

namespace AgriculturePresentationApp.Business.Services.Interfaces
{
    public interface IAdressService : IGenericService<Adress,AdressDTO,CreateAdressDTO,UpdateAdressDTO,GetAdressVM>
    {
    }
}
