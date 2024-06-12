using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I.Models
{
    public class Personel
    {
        public int PersonelID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public double Maas { get; set; }

        // Bu alanı tutmak ekstra iş yükünü azaltır.
        public int BolumID { get; set; }
        // Navigation Property
        public Bolum Bolum { get; set; }

        //public ICollection<Proje> Projeler { get; set; }
        public ICollection<PersonelProje> Projeler { get; set; }

        //---- 1 - 1 İÇİN
        public PersonelDetay PersonelDetay { get; set; }
    }
}
