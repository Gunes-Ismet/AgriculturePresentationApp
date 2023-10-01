using AgriculturePresentationApp.Business.Services.Interfaces;
using AgriculturePresentationApp.Entities.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationApp.Web.ViewComponents
{
    public class AnnouncementViewComponent : ViewComponent
    {
        private readonly IAnnouncementService _service;

        public AnnouncementViewComponent(IAnnouncementService service)
        {
            _service = service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _service.GetFilteredListAsync(
                select : x => new GetAnnouncementVM
                {
                   Id = x.Id,
                   Description = x.Description,
                   Date = x.Date,
                   Status = x.Status,
                   Title = x.Title
                },
                where : x => x.Status == true
                );
            return View(values);
        }
    }
}
