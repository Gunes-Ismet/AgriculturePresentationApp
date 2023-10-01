using AgriculturePresentationApp.Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationApp.Web.ViewComponents
{
    public class DashBoardMessagesViewComponent : ViewComponent
    {
        private readonly IContactService _service;

        public DashBoardMessagesViewComponent(IContactService service)
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
