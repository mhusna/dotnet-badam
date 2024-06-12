using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I_Hoca.Models
{
    public class Urun
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }

        public int KategoriID { get; set; }
        public Kategori? Kategori { get; set; }

        public override string ToString()
        {
            return $"{UrunID} - {UrunAdi} - {Fiyat} - {Kategori.KategoriAdi}";
            //return $"{UrunID} - {UrunAdi} - {Fiyat} - {Kategori.KategoriAdi}";
        }
    }
}
