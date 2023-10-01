using AgriculturePresentationApp.DataAccess.Contexts;
using AgriculturePresentationApp.DataAccess.Repositories.Interfaces;
using AgriculturePresentationApp.Entities.Entities.Concrete;

namespace AgriculturePresentationApp.DataAccess.Repositories.Concretes
{
	public class AboutRepository : GenericRepository<About>, IAboutRepository
	{
		public AboutRepository(AgriculturePresentationAppDbContext context) : base(context)
		{
		}
	}
}
