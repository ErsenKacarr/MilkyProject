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
            var appUser = new AppUser()
            {
                Name = createNewUserDto.Name,
                Surname = createNewUserDto.Surname,
                Email = createNewUserDto.Email,
                UserName = createNewUserDto.Username
            };
            var result = await _userManager.CreateAsync(appUser, createNewUserDto.Password);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}
