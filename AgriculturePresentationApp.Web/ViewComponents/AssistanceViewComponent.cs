using AgriculturePresentationApp.Business.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationApp.Web.ViewComponents
{
	public class AssistanceViewComponent : ViewComponent
	{
		private readonly IAssistanceService _service;

		public AssistanceViewComponent(IAssistanceService service)
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
