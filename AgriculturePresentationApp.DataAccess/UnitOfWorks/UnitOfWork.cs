using AgriculturePresentationApp.DataAccess.Contexts;

namespace AgriculturePresentationApp.DataAccess.UnitOfWorks
{
    public class UnitOfWork : IUnitofWork
    {
        private readonly AgriculturePresentationAppDbContext _context;
        public UnitOfWork(AgriculturePresentationAppDbContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }
        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
