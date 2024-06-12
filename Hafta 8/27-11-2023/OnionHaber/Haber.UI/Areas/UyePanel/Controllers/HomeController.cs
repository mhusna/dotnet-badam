using Haber.Application.Models.DTOs;
using Haber.Application.Services.AppUserService;
using Haber.Application.Services.YorumService;
using Haber.Domain.Repositories.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

namespace Haber.UI.Areas.UyePanel.Controllers
{
    [Area("UyePanel")]
    [Authorize(Roles = "Admin, Uye")]
    public class HomeController : Controller
    {
        private readonly IYorumService _yorumService;
        private readonly IAppUserService _appUserService;

        public HomeController(IYorumService yorumService, IAppUserService appUserService)
        {
            _yorumService = yorumService;
            _appUserService = appUserService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> YorumEkle(YorumEkleDTO yorum)
        {
            yorum.UserID = _appUserService.GetUserId(User);
            await _yorumService.YorumEkleAsync(yorum);
            return RedirectToAction("HaberDetay", "Home", new {Area = "", id = yorum.HaberID});
        }
    }
}
