using Microsoft.AspNetCore.Mvc;

namespace Haber.UI.Areas.UyePanel.Controllers
{
    [Area("UyePanel")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
