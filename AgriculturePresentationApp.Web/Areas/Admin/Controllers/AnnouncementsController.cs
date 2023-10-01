using AgriculturePresentationApp.Business.Services.Interfaces;
using AgriculturePresentationApp.Entities.DTO_s.AnnouncementDTO_s;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AnnouncementsController : Controller
    {
        private readonly IAnnouncementService _service;
        private readonly IMapper _mapper;

        public AnnouncementsController(IAnnouncementService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _service.GetAllListAsync();
            if (values == null)
            {
                TempData["Error"] = "Duyuru bulunamadı :(";
                return RedirectToAction("CreateAnnouncement");
            }
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateAnnouncement()
        { return View(); }
        [HttpPost]
        public async Task<IActionResult> CreateAnnouncement(CreateAnnouncementDTO model)
        {
            if (ModelState.IsValid)
            {
                await _service.CreateAsync(model);
                TempData["Success"] = "Duyuru başarılı bir şekilde eklenmiştir!!";
                return RedirectToAction(nameof(Index));
            }
            TempData["Error"] = "Lütfen kurallara uyunuz!!";
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> RemoveAnnouncement(int id)
        {
            await _service.RemoveAsync(id);
            if (await _service.AnyAsync(x => x.Id == id) == false)
            {
                TempData["Success"] = "Duyuru başarılı bir şekilde silindi!!";
                return RedirectToAction(nameof(Index));
            }
            TempData["Error"] = "Bir şeyler ters gitti :(";
            return NotFound();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateAnnouncement(int id)
        {
            var assistance = await _service.GetByIdAsync(id);
            if (assistance is not null)
            {
                var model = _mapper.Map<UpdateAnnouncementDTO>(assistance);
                return View(model);
            }
            TempData["Error"] = "Duyuru bulunamadı!! :(";
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAnnouncement(UpdateAnnouncementDTO model)
        {
            if (ModelState.IsValid)
            {
                await _service.UpdateAsync(model);
                TempData["Success"] = "Başarılı bir şekilde güncellendi!!";
                return RedirectToAction(nameof(Index));
            }
            TempData["Error"] = "Lütfen formu kurallara uygun doldurunuz!!";
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> StatusTrueFalse(int id)
        {
            if (await _service.AnyAsync(x => x.Id == id) == true)
            {
                var result = await _service.StatusTrueFalse(id);
                if (result == true)
                {
                    TempData["Success"] = "İşlem başarılı!!";
                    return RedirectToAction(nameof(Index));
                }
                TempData["Error"] = "Aktif duyuru sayısının 3'ten az olduğundan emin olun!!";
                return RedirectToAction(nameof(Index));
            }
            TempData["Error"] = "Duyuru bulunamadı!! :(";
            return NotFound();
        }
    }
}
