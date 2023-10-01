using AgriculturePresentationApp.Business.Services.Interfaces;
using AgriculturePresentationApp.Entities.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationApp.Web.ViewComponents
{
    public class DashBoardOverviewViewComponent : ViewComponent
    {
        private readonly ITeamService _teamService;
        private readonly IAssistanceService _assistanceService;
        private readonly IContactService _contactService;
        private readonly IAnnouncementService _announcementService;

        public DashBoardOverviewViewComponent(ITeamService teamService, IAssistanceService assistanceService, IContactService contactService, IAnnouncementService announcementService)
        {
            _teamService = teamService;
            _assistanceService = assistanceService;
            _contactService = contactService;
            _announcementService = announcementService;
        }
        public IViewComponentResult Invoke()
        {
            var teamCount = _teamService.Count();
            var assistanceCount = _assistanceService.Count();
            var messageCount = _contactService.Count();
            var announcementStatusTrueCount = _announcementService.GetFilteredListAsync(
                select : x => new GetAnnouncementVM
                {
                     Status = x.Status,
                },
                where: x => x.Status == true).Result.Count();
            var announcementStatusFalseCount = _announcementService.GetFilteredListAsync(
                select: x => new GetAnnouncementVM
                {
                    Status = x.Status,
                },
                where: x => x.Status == false).Result.Count();
            var countList = new List<int> { teamCount, assistanceCount, messageCount, announcementStatusTrueCount, announcementStatusFalseCount };
            return View(countList);
        }
    }
}
