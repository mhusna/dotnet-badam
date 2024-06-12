using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI_I.Models;

namespace WebAPI_I.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KitapController : ControllerBase
    {
        static List<Kitap> _kitaplar = new List<Kitap>()
        {
            new Kitap() { KitapID = 1, KitapAdi = "Denemeler", Yazar = "Montaigne", Fiyat = 120},
            new Kitap() { KitapID = 2, KitapAdi = "Suç ve Ceza", Yazar = "Dostoyevski", Fiyat = 100},
            new Kitap() { KitapID = 3, KitapAdi = "Başlangıç", Yazar = "Dan Brown", Fiyat = 124},
            new Kitap() { KitapID = 4, KitapAdi = "Da Vinci'nin Şifresi", Yazar = "Dan Brown", Fiyat = 100}
        };

        [HttpGet]
        public IActionResult TumKitaplar()
        {
            return Ok(_kitaplar);
        }

        [HttpGet("bul")]
        public IActionResult KitapBul(int? id)
        {
            if (id == null)
                return BadRequest();
            return Ok(_kitaplar.Find(x => x.KitapID == id));
        }

        [HttpPost]
        public IActionResult KitapEkle(Kitap kitap)
        {
            _kitaplar.Add(kitap);
            return Ok();
        }

        [HttpPut]
        public IActionResult KitapGuncelle(Kitap kitap)
        {
            var book = _kitaplar.Find(x => x.KitapID == kitap.KitapID);
            if (book == null)
                return BadRequest("Kitap bulunamadı..");

            book.KitapAdi = kitap.KitapAdi;
            book.Yazar = kitap.Yazar;
            book.Fiyat = kitap.Fiyat;

            return Ok();
        }

        [HttpDelete]
        public IActionResult KitapSil(int id)
        {
            var book = _kitaplar.Find(x => x.KitapID == id);

            _kitaplar.Remove(book);
            return Ok();
        }

    }
}
