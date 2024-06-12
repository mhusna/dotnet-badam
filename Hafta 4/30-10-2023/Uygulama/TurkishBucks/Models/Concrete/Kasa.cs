using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class Kasa
    {
        public int KasaNo { get; set; }
        public Calisan Calisan { get; set; }
        public Musteri Musteri { get; set; }
        public KasaDurum KasaDurum { get; set; }
    }
}
