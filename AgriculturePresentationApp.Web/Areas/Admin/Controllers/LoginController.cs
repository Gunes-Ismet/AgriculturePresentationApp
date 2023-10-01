using AgriculturePresentationApp.Entities.DTO_s.AdminDTO_s;
using AgriculturePresentationApp.Entities.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SignInResult = Microsoft.AspNetCore.Identity.SignInResult;

namespace AgriculturePresentationApp.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class LoginController : Controller
    {
        private readonly UserManager<ApplicationAdmin> _userManager;
        private readonly SignInManager<ApplicationAdmin> _signInManager;
        private readonly IPasswordHasher<ApplicationAdmin> _passwordHasher;

        public LoginController(UserManager<ApplicationAdmin> userManager, SignInManager<ApplicationAdmin> signInManager, IPasswordHasher<ApplicationAdmin> passwordHasher)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _passwordHasher = passwordHasher;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult LogIn() => View();

        [HttpPost, AllowAnonymous, ValidateAntiForgeryToken]
        public async Task<IActionResult> LogIn(LoginDTO model)
        {
            if (ModelState.IsValid)
            {
                ApplicationAdmin admin = await _userManager.FindByNameAsync(model.UserName);
                if (admin != null)
                {
                    SignInResult result = await _signInManager.PasswordSignInAsync(admin.UserName, model.Password, false, false);
                    if (result.Succeeded)
                    {
                        TempData["Success"] = "Hoşgeldiniz " + admin.UserName;
                        return RedirectToAction("Index", "DashBoard");
                    }
                }
                TempData["Error"] = "Kullanıcı adı veya şifre yanlış!!";
                return View(model);
            }
            TempData["Error"] = "Lütfen aşağıdaki kurallara uyunuz!!";
            return View(model);
        }
		public async Task<IActionResult> LogOut()
		{
			await _signInManager.SignOutAsync();
			return RedirectToAction("Index");
		}
        [HttpGet]
        public async Task<IActionResult> UpdateAdmin()
        {
            ApplicationAdmin user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (user != null)
            {
                var model = new UpdateAdminDTO(user);
                return View(model);
            }
            return NotFound();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateAdmin(UpdateAdminDTO model)
        {
            if (ModelState.IsValid)
            {
                ApplicationAdmin user = await _userManager.FindByNameAsync(User.Identity.Name);
                user.UserName = model.UserName;
                if (model.Password != null)
                {
                    user.PasswordHash = _passwordHasher.HashPassword(user, model.Password);
                }

                IdentityResult result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    TempData["Success"] = "Profil bilgileri güncellendi!";
                }
                else
                {
                    TempData["Error"] = "Profil bilgilerinin güncellenemedi!!";
                }
                return View(model);
            }
            TempData["Error"] = "Lütfen aşağıdaki kurallara uyunuz!";
            return View(model);
        }
    }
}
