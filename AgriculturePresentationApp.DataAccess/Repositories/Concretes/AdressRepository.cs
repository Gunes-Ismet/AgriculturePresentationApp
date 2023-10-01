using AgriculturePresentationApp.DataAccess.Contexts;
using AgriculturePresentationApp.DataAccess.Repositories.Interfaces;
using AgriculturePresentationApp.Entities.Entities.Concrete;

namespace AgriculturePresentationApp.DataAccess.Repositories.Concretes
{
    public class AdressRepository : GenericRepository<Adress>, IAdressRepository
    {
        public AdressRepository(AgriculturePresentationAppDbContext context) : base(context)
        {
        }
    }
}
