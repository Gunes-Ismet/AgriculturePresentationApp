using AgriculturePresentationApp.Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationApp.Web.ViewComponents
{
    public class DashBoardTableViewComponent : ViewComponent
    {
        private readonly ITeamService _service;

        public DashBoardTableViewComponent(ITeamService service)
        {
            _service = service;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _service.GetAllListAsync();
            return View(values);
        }
    }
}
