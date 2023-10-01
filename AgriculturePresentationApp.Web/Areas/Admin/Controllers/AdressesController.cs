using AgriculturePresentationApp.Business.Services.Interfaces;
using AgriculturePresentationApp.Entities.DTO_s.AdressDTO_s;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdressesController : Controller
    {
        private readonly IAdressService _service;
        private readonly IMapper _mapper;

        public AdressesController(IAdressService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var values = await _service.GetAllListAsync();
            if (values == null)
            {
                TempData["Error"] = "Adres bulunamadı :(";
                return View();
            }
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> UpdateAdress(int id)
        {
            var assistance = await _service.GetByIdAsync(id);
            if (assistance is not null)
            {
                var model = _mapper.Map<UpdateAdressDTO>(assistance);
                return View(model);
            }
            TempData["Error"] = "Adres bulunamadı!! :(";
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateAdress(UpdateAdressDTO model)
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
