using Haber.Application.Models.DTOs;
using Haber.Application.Services.AppUserService;
using Microsoft.AspNetCore.Mvc;

namespace Haber.UI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IAppUserService _appUserService;

        public LoginController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO loginDto)
        {
            //return await _appUserService.LoginAsync(loginDto) ? RedirectToAction("Index") : View();

            bool result = await _appUserService.LoginAsync(loginDto);
            return Content(result.ToString());
        }
    }
}
