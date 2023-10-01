using AgriculturePresentationApp.Business.Services.Interfaces;
using AgriculturePresentationApp.DataAccess.Repositories.Interfaces;
using AgriculturePresentationApp.DataAccess.UnitOfWorks;
using AgriculturePresentationApp.Entities.DTO_s.AdressDTO_s;
using AgriculturePresentationApp.Entities.Entities.Concrete;
using AgriculturePresentationApp.Entities.Models.ViewModels;
using AutoMapper;

namespace AgriculturePresentationApp.Business.Services.Concretes
{
    public class AdressService : GenericService<Adress,AdressDTO,CreateAdressDTO,UpdateAdressDTO,GetAdressVM>, IAdressService
    {
        public AdressService(IGenericRepository<Adress> repository, IUnitofWork unitofWork, IMapper mapper) : base(repository, unitofWork, mapper)
        {
        }
    }
}
