using AgriculturePresentationApp.Business.Services.Interfaces;
using AgriculturePresentationApp.Entities.DTO_s.ContactDTO_s;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationApp.Web.Controllers
{
	[AllowAnonymous]
	public class HomeController : Controller
	{
		private readonly IContactService _service;

		public HomeController(IContactService service)
		{
			_service = service;
		}
		public IActionResult Index()
		{
			return View();
		}
		[HttpGet]
		public PartialViewResult SendMessage()
		{
			return PartialView();
		}
		[HttpPost]
		public async Task<IActionResult> SendMessage(CreateContactDTO model)
		{
			await _service.CreateAsync(model);
			return RedirectToAction(nameof(Index));
		}
		public PartialViewResult ScriptPartial()
		{
			return PartialView();
		}
	}
}
