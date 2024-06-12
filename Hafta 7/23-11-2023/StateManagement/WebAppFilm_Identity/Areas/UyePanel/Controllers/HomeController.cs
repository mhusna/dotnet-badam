using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAppFilm_Identity.Areas.UyePanel.Controllers
{
    [Area("UyePanel")]
    [Authorize(Roles ="Admin,Uye")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
