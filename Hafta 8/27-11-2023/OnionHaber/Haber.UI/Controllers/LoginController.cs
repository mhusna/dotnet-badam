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
            LoginReturnDTO loginReturnDTO = await _appUserService.LoginAsync(loginDto);

            if (loginReturnDTO.IsUser)
            {
                if (loginReturnDTO.IsAdmin)
                    return RedirectToAction("Index", "Home", new { area = "AdminPanel" });
                else
                    return RedirectToAction("Index", "Home", new { area = "UyePanel" });
            }
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UyeKayitDTO uye)
        {
            bool result;

            if (uye.Password == uye.ConfirmPassword)
            {
                result = await _appUserService.RegisterAsync(uye);
                return RedirectToAction("Login");
            }
            else
            {
                ModelState.AddModelError("Sifre", "Sifreler aynı olmalı..");
                return View(uye);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _appUserService.LogoutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
