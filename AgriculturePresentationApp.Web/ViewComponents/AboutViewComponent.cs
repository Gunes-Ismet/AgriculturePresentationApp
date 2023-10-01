using AgriculturePresentationApp.Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationApp.Web.ViewComponents
{
	public class AboutViewComponent : ViewComponent
	{
		private readonly IAboutService _aboutService;

		public AboutViewComponent(IAboutService aboutService)
		{
			_aboutService = aboutService;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _aboutService.GetAllListAsync();
			return View(values);
		}
	}
}
