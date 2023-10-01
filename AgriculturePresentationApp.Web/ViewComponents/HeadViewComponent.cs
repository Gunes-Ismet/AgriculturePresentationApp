using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationApp.Web.ViewComponents
{
	public class HeadViewComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
