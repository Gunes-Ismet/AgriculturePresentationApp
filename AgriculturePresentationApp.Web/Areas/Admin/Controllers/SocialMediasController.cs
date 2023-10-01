using AgriculturePresentationApp.Business.Services.Interfaces;
using AgriculturePresentationApp.Entities.DTO_s.AssistanceDTO_s;
using AgriculturePresentationApp.Entities.DTO_s.SocialMediaDTO_s;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SocialMediasController : Controller
    {
        private readonly ISocialMediaService _service;
        private readonly IMapper _mapper;

        public SocialMediasController(ISocialMediaService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var values = await _service.GetAllListAsync();
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateSocialMedia(int id)
        {
            var assistance = await _service.GetByIdAsync(id);
            if (assistance is not null)
            {
                var model = _mapper.Map<UpdateSocialMediaDTO>(assistance);
                return View(model);
            }
            TempData["Error"] = "Sosyal medya bulunamadı!! :(";
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateSocialMedia(UpdateSocialMediaDTO model)
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
