using Microsoft.AspNetCore.Mvc;
using MVC_Uygulamasi.Models;
using System.Diagnostics;

namespace MVC_Uygulamasi.Controllers
{
    public class HomeController : Controller
    {
        DataUtility utility = new DataUtility();
        public async Task<IActionResult> Index()
        {
            return View(await utility.VerileriGetir("https://localhost:7105/api/Products"));
        }

        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Ekle(Product product)
        {
            await utility.VeriEkle("https://localhost:7105/api/Products", product);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Guncelle(int id)
        {
            Product product = await utility.VeriGetir("https://localhost:7105/api/Products/", id);
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Guncelle(Product product)
        {
            await utility.VeriGuncelle("https://localhost:7105/api/Products/", product);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> Sil(int ProductID)
        {
            await utility.VeriSil($"https://localhost:7105/api/Products/{ProductID}");
            return RedirectToAction("Index");
        }
    }
}