using AgriculturePresentationApp.DataAccess.Contexts;
using AgriculturePresentationApp.DataAccess.Repositories.Interfaces;
using AgriculturePresentationApp.Entities.Entities.Concrete;

namespace AgriculturePresentationApp.DataAccess.Repositories.Concretes
{
    public class ContactRepository : GenericRepository<Contact>, IContactRepository
    {
        public ContactRepository(AgriculturePresentationAppDbContext context) : base(context)
        {
        }
    }
}
