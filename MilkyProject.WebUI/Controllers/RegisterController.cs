using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MilkyProject.EntityLayer.Concrete;
using MilkyProject.WebUI.Dtos.RegisterDto;

namespace MilkyProject.WebUI.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateNewUserDto createNewUserDto)
        {
            if (createNewUserDto.Password != null)
            {
                AppUser appUser = new AppUser()
                {
                    Name = createNewUserDto.Name,
                    Email = createNewUserDto.Email,
                    Surname = createNewUserDto.Surname,
                    UserName = createNewUserDto.Username,
                };

                var result = await _userManager.CreateAsync(appUser, createNewUserDto.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
                return View();
            }
            else
            {
                ModelState.AddModelError("", "Şifre alanı boş geçilemez");
                return View();
            }
        }
    }
}
