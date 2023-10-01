using AgriculturePresentationApp.DataAccess.Contexts;
using AgriculturePresentationApp.DataAccess.Repositories.Interfaces;
using AgriculturePresentationApp.Entities.Entities.Concrete;

namespace AgriculturePresentationApp.DataAccess.Repositories.Concretes
{
	public class SocialMediaRepository : GenericRepository<SocialMedia>, ISocialMediaRepository
	{
		public SocialMediaRepository(AgriculturePresentationAppDbContext context) : base(context)
		{
		}
	}
}
