using Microsoft.AspNetCore.Mvc;
using MVC_Core.Models;

namespace MVC_Core.Controllers
{
    public class VeriAlController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult QueryStringYakala()
        {
            return Content(Request.QueryString.Value);
        }

        [HttpPost]
        public IActionResult RequestFormYakala()
        {
            Urun urun = new Urun();

            // Name özelliğini yazıyoruz parantez içerisine.
            // Tüm form elemanlarının isimleri doğru yazılmalıdır.
            urun.UrunID = int.Parse(Request.Form["id"]);
            urun.UrunAdi = Request.Form["ad"];
            urun.Fiyat = double.Parse(Request.Form["fiyat"]);
            return Content(urun.UrunID.ToString()+" "+ urun.UrunAdi+" "+ urun.Fiyat);
        }
    }
}
