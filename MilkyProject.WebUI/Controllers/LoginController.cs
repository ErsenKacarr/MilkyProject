using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.EntityLayer.Concrete;
using MilkyProject.WebUI.Dtos.LoginDtos;
using MilkyProject.WebUI.Models;

namespace MilkyProject.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(ResultLoginDto model)
        {

            var result = await _signInManager.PasswordSignInAsync(model.Name, model.Password, false, true);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "UILayout");
            }
            else
            {
                ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı");
            }
            {
                ModelState.AddModelError("", "Lütfen alanları boş geçmeyin!");
            }
            return View();
        }
    }
}
