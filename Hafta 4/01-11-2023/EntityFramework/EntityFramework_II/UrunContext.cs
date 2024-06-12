using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_II
{
    public class UrunContext
    {
        public List<Urun> Urunler { get; set; }
        public List<Kategori> Kategoriler { get; set; }
        public UrunContext()
        {
            Kategoriler = new List<Kategori>()
            {
                new Kategori(){ KategoriID = 1, KategoriAdi = "Kirtasiye"},
                new Kategori(){ KategoriID = 2, KategoriAdi = "Hobi"},
                new Kategori(){ KategoriID = 3, KategoriAdi = "Hediyelik"},
                new Kategori(){ KategoriID = 4, KategoriAdi = "Tekstil"}
            };

            Urunler = new List<Urun>()
            {
                new Urun(){ UrunID = 123, UrunAdi = "Defter", Fiyat = 44, KategoriID = 1},
                new Urun(){ UrunID = 124, UrunAdi = "Pergel", Fiyat = 55, KategoriID = 1},
                new Urun(){ UrunID = 125, UrunAdi = "Maket Uçak", Fiyat = 1200, KategoriID = 2},
                new Urun(){ UrunID = 126, UrunAdi = "Anahtarlık", Fiyat = 20, KategoriID = 3},
                new Urun(){ UrunID = 127, UrunAdi = "İsimlik", Fiyat = 25, KategoriID = 3},
                new Urun(){ UrunID = 128, UrunAdi = "T-Shirt", Fiyat = 100, KategoriID = 4}
            };
        }
    }
}
