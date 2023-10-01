using AgriculturePresentationApp.Business.Services.Interfaces;
using AgriculturePresentationApp.Entities.DTO_s.AssistanceDTO_s;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AssistancesController : Controller
    {
        private readonly IAssistanceService _service;
        private readonly IMapper _mapper;

        public AssistancesController(IAssistanceService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var values = await _service.GetAllListAsync();
            if (values == null)
            {
                TempData["Error"] = "Hizmet bulunamadı :(";
                return RedirectToAction("CreateAssistance");
            }
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateAssistance()
        { return View(); }
        [HttpPost]
        public async Task<IActionResult> CreateAssistance(CreateAssistanceDTO model)
        {
            if (ModelState.IsValid)
            {
                await _service.CreateAsync(model);
                TempData["Success"] = "Hizmet başarılı bir şekilde eklenmiştir!!";
                return RedirectToAction(nameof(Index));
            }
            TempData["Error"] = "Lütfen kurallara uyunuz!!";
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> RemoveAssistance(int id)
        {        
                await _service.RemoveAsync(id);
            if (await _service.AnyAsync(x => x.Id == id) == false)
            {
                TempData["Success"] = "Hizmet başarılı bir şekilde silindi!!";
                return RedirectToAction(nameof(Index));
            }
            TempData["Error"] = "Hizmet bulunamadı :(";
            return NotFound();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateAssistance(int id)
        {
            var assistance = await _service.GetByIdAsync(id);
            if (assistance is not null)
            {
                var model = _mapper.Map<UpdateAssistanceDTO>(assistance);
                return View(model);
            }
            TempData["Error"] = "Hizmet bulunamadı!! :(";
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAssistance(UpdateAssistanceDTO model)
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
