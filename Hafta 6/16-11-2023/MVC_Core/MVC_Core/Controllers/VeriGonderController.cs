using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Core.Models;

namespace MVC_Core.Controllers
{
    public class VeriGonderController : Controller
    {
        
        public IActionResult Index()
        {
            ViewData["Mesaj"] = "Merhaba MVC";
            ViewBag.Message = "Hello MVC";

            Urun urun = new Urun() { UrunID = 1, UrunAdi = "Çaydanlık", Fiyat = 35.44};

            ViewData["urun1"] = urun;
            ViewBag.Urun = urun;

            // Veriler kolleksiyon olursa.
            List<Urun> list = new List<Urun>()
            {
                new Urun(){ UrunID = 123, UrunAdi = "Defter", Fiyat = 45},
                new Urun(){ UrunID = 124, UrunAdi = "Kalem", Fiyat = 10},
                new Urun(){ UrunID = 125, UrunAdi = "Silgi", Fiyat = 8}
            };

            ViewData["liste"] = list;
            ViewBag.Liste = list;

            ViewData["test"] = list;

            return View();
        }

        public IActionResult Temp_Data()
        {
            TempData["testValue"] = "test123";
            TempData.Keep("testValue");
            return View();
        }

        public IActionResult Test()
        {
            string data = TempData["testValue"].ToString();
            TempData.Keep("testValue");
            return Content("Test " + data);
        }

        public IActionResult ModelKullan()
        {
            // Tek bir nesne olursa..
            //Urun urun = new Urun() { UrunID = 1, UrunAdi = "Çaydanlık", Fiyat = 35.44 }; 

            // Birden fazla nesne ise
            List<Urun> list = new List<Urun>()
            {
                new Urun(){ UrunID = 123, UrunAdi = "Defter", Fiyat = 45},
                new Urun(){ UrunID = 124, UrunAdi = "Kalem", Fiyat = 10},
                new Urun(){ UrunID = 125, UrunAdi = "Silgi", Fiyat = 8}
            };

            return View(list);
        }

        public IActionResult ViewModelKullan()
        {
            /* 
                // ViewModel Kullanmadan

            ViewBag.Kategoriler = new SelectList(KitapDB.Kategoriler, "KategoriID", "KategoriAdi");
            ViewBag.Yazarlar = new SelectList(KitapDB.Yazarlar, "YazarID", "YazarAdSoyad");

            */


            // ViewModel Kullanarak
            KitapEkleVM kitapVM = new KitapEkleVM();
            kitapVM.Kategoriler = new SelectList(KitapDB.Kategoriler, "KategoriID", "KategoriAdi");
            kitapVM.Yazarlar = new SelectList(KitapDB.Yazarlar, "YazarID", "YazarAdSoyad");

            return View(kitapVM);
        }
    }
}
