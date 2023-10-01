using AgriculturePresentationApp.Business.Services.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ContactsController : Controller
    {
        private readonly IContactService _service;
        private readonly IMapper _mapper;

        public ContactsController(IContactService service,IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var values = await _service.GetAllListAsync();
            if (values == null)
            {
                TempData["Error"] = "Mesaj bulunamadı :(";
                return NotFound();
            }
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> RemoveMessage(int id)
        {
            await _service.RemoveAsync(id);
            if (await _service.AnyAsync(x => x.Id == id) == false)
            {
                TempData["Success"] = "Mesaj başarılı bir şekilde silindi!!";
                return RedirectToAction(nameof(Index));
            }
            TempData["Error"] = "Mesaj bulunamadı :(";
            return NotFound();
        }

    }
}
