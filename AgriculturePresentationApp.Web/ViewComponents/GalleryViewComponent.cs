using AgriculturePresentationApp.Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationApp.Web.ViewComponents
{
	public class GalleryViewComponent : ViewComponent
	{
		private readonly IImageService _service;

		public GalleryViewComponent(IImageService service)
        {
			_service = service;
		}

		public async Task<IViewComponentResult> InvokeAsync() 
		{ 
			var values =await _service.GetAllListAsync();
			return View(values);
		}
    }
}
