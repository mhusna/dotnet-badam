using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MVC_Core.Models;

namespace MVC_Core.Controllers
{
    public class KitapController : Controller
    {
        public IActionResult Index()
        {
            var sonuc = from kitap in KitapDB.Kitaplar
            join kategori in KitapDB.Kategoriler on kitap.KategoriID equals kategori.KategoriID
            join yazar in KitapDB.Yazarlar on kitap.YazarID equals yazar.YazarID
            select new KitapListeleVM 
            { 
                KitapID = kitap.KitapID,
                KitapAdi = kitap.KitapAdi,
                Fiyat = kitap.Fiyat, 
                KategoriAdi = kategori.KategoriAdi,
                YazarAdi = yazar.YazarAdSoyad
            };

            return View(sonuc.ToList());
        }

        [HttpGet]
        public IActionResult KitapEkle()
        {
            KitapEkleVM kitapVM = new KitapEkleVM();
            kitapVM.Kategoriler = new SelectList(KitapDB.Kategoriler, "KategoriID", "KategoriAdi");
            kitapVM.Yazarlar = new SelectList(KitapDB.Yazarlar, "YazarID", "YazarAdSoyad");
            
            return View(kitapVM);
        }
        [HttpPost]
        public IActionResult KitapEkle(Kitap kitap)
        {
            kitap.KitapID = KitapDB.Identity;

            KitapDB.Kitaplar.Add(kitap);
            return RedirectToAction("Index");
        }

        public IActionResult ResimIleListele()
        {
            var sonuc = from kitap in KitapDB.Kitaplar
                        join kategori in KitapDB.Kategoriler on kitap.KategoriID equals kategori.KategoriID
                        join yazar in KitapDB.Yazarlar on kitap.YazarID equals yazar.YazarID
                        select new KitapListeleVM
                        {
                            KitapID = kitap.KitapID,
                            KitapAdi = kitap.KitapAdi,
                            Fiyat = kitap.Fiyat,
                            KategoriAdi = kategori.KategoriAdi,
                            YazarAdi = yazar.YazarAdSoyad,
                            FilePath = kitap.FilePath
                        };

            return View(sonuc.ToList());
        }


        public IActionResult ResimIleKitapEkle()
        {
            KitapEkleVM kitapVM = new KitapEkleVM();
            kitapVM.Kategoriler = new SelectList(KitapDB.Kategoriler, "KategoriID", "KategoriAdi");
            kitapVM.Yazarlar = new SelectList(KitapDB.Yazarlar, "YazarID", "YazarAdSoyad");

            return View(kitapVM);
        }

        [HttpPost]
        public IActionResult ResimIleKitapEkle(Kitap kitap)
        {
            kitap.KitapID = KitapDB.Identity;

            // Resim dosyasını sunucuya kaydet..

            string guid = Guid.NewGuid().ToString()+ "_" + kitap.File.FileName;

            // GUIDSIZ
            // string strFilePath = "wwwroot/KapakResimleri/"+kitap.File.FileName;

            string strFilePath = "wwwroot/KapakResimleri/" + guid;
            FileStream fileStream = new FileStream(strFilePath, FileMode.Create);
            kitap.File.CopyTo(fileStream);
            fileStream.Close();

            //kitap.FilePath = strFilePath;
            kitap.FilePath =  guid;

            KitapDB.Kitaplar.Add(kitap);
            return RedirectToAction("ResimIleListele");
        }
    }
}
