using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calisma2
{
    internal class Personel
    {
        public static int kacPersonel = 0;
        public int PersonelID { get; set; }
        public string PersonelAd { get; set; }
        public string PersonelSoyad { get; set; }
        public string Adres { get; set; }

        public Personel(string ad, string soyad, string adres)
        {
            kacPersonel += 1;

            PersonelID = kacPersonel;
            PersonelAd = ad;
            PersonelSoyad = soyad;
            Adres = adres;
        }
    }
}
