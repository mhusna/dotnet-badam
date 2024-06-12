using System.ComponentModel.DataAnnotations;

namespace MVC_Core.Models
{
    public class Kitap
    {
        public int KitapID { get; set; }

        [Display(Name ="Kitap Adı:")]
        public string KitapAdi { get; set; }

        [Display(Name = "Fiyat:")]
        public double Fiyat { get; set; }

        // Duruma göre bu iki kullanımdan biri kullanılır.
        //Model katmanında IFormFile kullanılmamalı.
        [Display(Name = "Resim Yolu: ")]
        public string FilePath { get; set; }

        [Display(Name = "Resim:")]
        public IFormFile File { get; set; }

        [Display(Name = "Kategori:")]
        public int KategoriID { get; set; }

        [Display(Name = "Yazar:")]
        public int YazarID { get; set; }
    }
}
