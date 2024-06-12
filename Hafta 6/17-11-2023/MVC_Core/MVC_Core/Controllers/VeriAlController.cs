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

        public IActionResult IFormCollectionYakala(IFormCollection frm)
        {
            // Name özelliğini yazıyoruz parantez içerisine.
            // Tüm form elemanlarının isimleri doğru yazılmalıdır.
            // Uzun uzun request.form yazmaya gerek yok.
            Urun urun = new Urun();
            urun.UrunID = int.Parse(frm["id"]);
            urun.UrunAdi = frm["ad"];
            urun.Fiyat = double.Parse(frm["fiyat"]);
            return Content(urun.UrunID.ToString() + " " + urun.UrunAdi + " " + urun.Fiyat);
        }

        public IActionResult ParametreYakala(int id, string ad, double fiyat)
        {
            // Parametre olarak gelen değerler ile formda tanımlı olan name'ler aynı olmalı.
            return Content(id + " " + ad + " " + fiyat);
        }

        public IActionResult ModelYakala(Urun urun)
        {
            return Content($"{urun.UrunID} {urun.UrunAdi} {urun.Fiyat}");
        }
    }
}
