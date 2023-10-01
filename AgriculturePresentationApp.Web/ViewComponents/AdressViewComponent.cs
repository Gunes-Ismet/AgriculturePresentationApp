using AgriculturePresentationApp.Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationApp.Web.ViewComponents
{
    public class AdressViewComponent : ViewComponent
    {
        private readonly IAdressService _service;

        public AdressViewComponent(IAdressService service)
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
