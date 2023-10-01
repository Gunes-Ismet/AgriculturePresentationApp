using AgriculturePresentationApp.Business.Services.Interfaces;
using AgriculturePresentationApp.Entities.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationApp.Web.ViewComponents
{
    public class MapViewComponent : ViewComponent
    {
		private readonly IAdressService _service;

		public MapViewComponent(IAdressService service)
        {
			_service = service;
		}
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _service.GetFilteredListAsync(
                select: x => new GetAdressVM
                {
                    MapInfo = x.MapInfo,
                });
            return View(values);
        }
    }
}
