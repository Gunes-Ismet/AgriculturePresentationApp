using AgriculturePresentationApp.DataAccess.Contexts;
using AgriculturePresentationApp.DataAccess.Repositories.Interfaces;
using AgriculturePresentationApp.Entities.Entities.Concrete;

namespace AgriculturePresentationApp.DataAccess.Repositories.Concretes
{
    public class AssistanceRepository : GenericRepository<Assistance>, IAssistanceRepository
    {
        public AssistanceRepository(AgriculturePresentationAppDbContext context) : base(context)
        {
        }
    }
}
