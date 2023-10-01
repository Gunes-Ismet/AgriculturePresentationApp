using AgriculturePresentationApp.Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationApp.Web.ViewComponents
{
	public class TopAdressViewComponent :ViewComponent
	{
		private readonly IAdressService _adressService;

		public TopAdressViewComponent(IAdressService adressService)
        {
			_adressService = adressService;
		}
        public async Task<IViewComponentResult> InvokeAsync()
		{
			var values = await _adressService.GetAllListAsync();
			return View(values);
		}
	}
}
