using Microsoft.AspNetCore.Mvc;

namespace MVC_Core.Controllers
{
    public class BaslangicController : Controller
    {
        //public IActionResult Index()
        //{
        //    return View();
        //}

        public string Index()
        {
            return "Merhaba";
        }

        public string Detay()
        {
            return "Detaylar";
        }

        public string Html()
        {
            return "<h1>Merhaba MVC</h1>";
        }

        public IActionResult Yaz()
        {
            return Content("Yaz");
        }

        public IActionResult SayfaGoster()
        {
            return View();
        }
    }
}
