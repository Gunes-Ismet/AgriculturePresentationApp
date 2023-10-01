using AgriculturePresentationApp.Entities.DTO_s.AnnouncementDTO_s;
using AgriculturePresentationApp.Entities.Entities.Concrete;
using AgriculturePresentationApp.Entities.Models.ViewModels;

namespace AgriculturePresentationApp.Business.Services.Interfaces
{
    public interface IAnnouncementService : IGenericService<Announcement, AnnouncementDTO,CreateAnnouncementDTO,UpdateAnnouncementDTO,GetAnnouncementVM>
    {
        Task<bool> StatusTrueFalse(int id);

        public bool AreThereThreeAnnouncements();
    }
}
