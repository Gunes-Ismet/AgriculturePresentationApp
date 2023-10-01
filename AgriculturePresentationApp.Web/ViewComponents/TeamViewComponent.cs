using AgriculturePresentationApp.Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationApp.Web.ViewComponents
{
    public class TeamViewComponent : ViewComponent
    {
        private readonly ITeamService _service;
        public TeamViewComponent(ITeamService service)
        {
            _service = service;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _service.GetAllListAsync();
            return  View(values);
        }
    }
}
