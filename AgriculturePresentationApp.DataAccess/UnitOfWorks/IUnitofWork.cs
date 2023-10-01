namespace AgriculturePresentationApp.DataAccess.UnitOfWorks
{
    public interface IUnitofWork
    {
        Task CommitAsync();
        void Commit();
    }
}
