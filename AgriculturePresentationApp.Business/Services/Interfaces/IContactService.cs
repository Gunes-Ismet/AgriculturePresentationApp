using AgriculturePresentationApp.Entities.DTO_s.ContactDTO_s;
using AgriculturePresentationApp.Entities.Entities.Concrete;
using AgriculturePresentationApp.Entities.Models.ViewModels;

namespace AgriculturePresentationApp.Business.Services.Interfaces
{
    public interface IContactService : IGenericService<Contact, ContactDTO, CreateContactDTO, UpdateContactDTO, GetContactVM>
    {
    }
}
