using AgriculturePresentationApp.Business.Services.Interfaces;
using AgriculturePresentationApp.DataAccess.Repositories.Interfaces;
using AgriculturePresentationApp.DataAccess.UnitOfWorks;
using AgriculturePresentationApp.Entities.DTO_s.AnnouncementDTO_s;
using AgriculturePresentationApp.Entities.Entities.Concrete;
using AgriculturePresentationApp.Entities.Models.ViewModels;
using AutoMapper;

namespace AgriculturePresentationApp.Business.Services.Concretes
{
    public class AnnouncementService : GenericService<Announcement,AnnouncementDTO,CreateAnnouncementDTO,UpdateAnnouncementDTO,GetAnnouncementVM>, IAnnouncementService
    {
        private readonly IAnnouncementRepository _announcementRepository;

        public AnnouncementService(IGenericRepository<Announcement> repository, IUnitofWork unitofWork, IMapper mapper, IAnnouncementRepository announcementRepository) : base(repository, unitofWork, mapper)
        {
            _announcementRepository = announcementRepository;
        }

        public bool AreThereThreeAnnouncements()
        {
            var announcements = _announcementRepository.GetAllList().Where(x => x.Status == true).ToList();
            if (announcements.Count < 3)
                return false;
            
            else
                return true;
            
        }

        public async Task<bool> StatusTrueFalse(int id)
        {
            var announcement = await _announcementRepository.GetByIdAsync(id);
            if (announcement.Status == true)
            {
                announcement.Status = false;
                _announcementRepository.Update(announcement);
                await _unitofWork.CommitAsync();
                return true;
            }
            else
            {
                if (AreThereThreeAnnouncements() == false)
                {
                    announcement.Status = true;
                    _announcementRepository.Update(announcement);
                    await _unitofWork.CommitAsync();
                    return true;
                }
                return false;
            }                        
        }
    }
}
