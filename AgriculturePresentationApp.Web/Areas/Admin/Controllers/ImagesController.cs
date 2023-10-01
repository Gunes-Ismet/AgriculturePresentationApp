using AgriculturePresentationApp.Business.Services.Interfaces;
using AgriculturePresentationApp.Entities.DTO_s.ImageDTO_s;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ImagesController : Controller
    {
        private readonly IImageService _service;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ImagesController(IImageService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var values = await _service.GetAllListAsync();
            if (values == null)
            {
                TempData["Error"] = "Görsel bulunamadı :(";
                return RedirectToAction("AddAssistance");
            }
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateImage()
        { return View(); }
        [HttpPost]
        public async Task<IActionResult> CreateImage(CreateImageDTO model)
        {
            if (ModelState.IsValid)
            {
                await _service.CreateAsync(model);
                TempData["Success"] = "Görsel başarılı bir şekilde eklenmiştir!!";
                return RedirectToAction(nameof(Index));
            }
            TempData["Error"] = "Lütfen kurallara uyunuz!!";
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> RemoveImage(int id)
        {
            await _service.RemoveAsync(id);
            if (await _service.AnyAsync(x => x.Id == id) == false)
            {
                TempData["Success"] = "Görsel başarılı bir şekilde silindi!!";
                return RedirectToAction(nameof(Index));
            }
            TempData["Error"] = "Görsel bulunamadı!! :(";
            return NotFound();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateImage(int id)
        {
            var image = await _service.GetByIdAsync(id);
            if (image is not null)
            {
                var model = _mapper.Map<UpdateImageDTO>(image);
                return View(model);
            }
            TempData["Error"] = "Görsel bulunamadı!! :(";
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateImage(UpdateImageDTO model)
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
    }
}
