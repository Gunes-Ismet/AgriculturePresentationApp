using AgriculturePresentationApp.Business.Services.Interfaces;
using AgriculturePresentationApp.DataAccess.Repositories.Interfaces;
using AgriculturePresentationApp.DataAccess.UnitOfWorks;
using AgriculturePresentationApp.Entities.DTO_s.ContactDTO_s;
using AgriculturePresentationApp.Entities.Entities.Concrete;
using AgriculturePresentationApp.Entities.Models.ViewModels;
using AutoMapper;

namespace AgriculturePresentationApp.Business.Services.Concretes
{
    public class ContactService : GenericService<Contact,ContactDTO,CreateContactDTO,UpdateContactDTO,GetContactVM>, IContactService
    {
        public ContactService(IGenericRepository<Contact> repository, IUnitofWork unitofWork, IMapper mapper) : base(repository, unitofWork, mapper)
        {
        }
    }
}
