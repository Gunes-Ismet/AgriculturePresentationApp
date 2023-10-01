using AgriculturePresentationApp.Business.Services.Interfaces;
using AgriculturePresentationApp.Entities.DTO_s.TeamDTO_s;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentationApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeamsController : Controller
    {
        private readonly ITeamService _service;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public TeamsController(ITeamService teamService, IMapper mapper)
        {
            _service = teamService;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var values = await _service.GetAllListAsync();
            if (values == null)
            {
                TempData["Error"] = "Takım üyesi bulunamadı :(";
                return RedirectToAction("CreateTeam");
            }
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateTeam()
        { return View(); }
        [HttpPost]
        public async Task<IActionResult> CreateTeam(CreateTeamDTO model)
        {
            if (ModelState.IsValid)
            {                
                await _service.CreateAsync(model);
                TempData["Success"] = "Takım üyesi başarılı bir şekilde eklenmiştir!!";
                return RedirectToAction(nameof(Index));
            }
            TempData["Error"] = "Lütfen kurallara uyunuz!!";
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> RemoveTeam(int id)
        {            
            await _service.RemoveAsync(id);
            if (await _service.AnyAsync(x => x.Id == id) == false)
            {
                TempData["Success"] = "Takım üyesi başarılı bir şekilde silindi!!";
                return RedirectToAction(nameof(Index));
            }
            TempData["Error"] = "Takım üyesi bulunamadı :(";
            return NotFound();
        }
        [HttpGet]
        public async Task<IActionResult> UpdateTeam(int id)
        {
            var team = await _service.GetByIdAsync(id);
            if (team is not null)
            {
                var model = _mapper.Map<UpdateTeamDTO>(team);
                return View(model);
            }
            TempData["Error"] = "Takım üyesi bulunamadı!! :(";
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateTeam(UpdateTeamDTO model)
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
