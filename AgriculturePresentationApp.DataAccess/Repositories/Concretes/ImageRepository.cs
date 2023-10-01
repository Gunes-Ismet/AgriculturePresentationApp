using AgriculturePresentationApp.DataAccess.Contexts;
using AgriculturePresentationApp.DataAccess.Repositories.Interfaces;
using AgriculturePresentationApp.Entities.Entities.Concrete;

namespace AgriculturePresentationApp.DataAccess.Repositories.Concretes
{
    public class ImageRepository : GenericRepository<Image>, IImageRepository
    {
        public ImageRepository(AgriculturePresentationAppDbContext context) : base(context)
        {
        }
    }
}
