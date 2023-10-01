using AgriculturePresentationApp.Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationApp.Web.ViewComponents
{
	public class SocialMediaViewComponent : ViewComponent
	{
		private readonly ISocialMediaService _service;

		public SocialMediaViewComponent(ISocialMediaService service)
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
