using Models.Abstract;
using Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class Calisan : Kisi
    {
        public double Maas { get; set; }
        public CalisanKonum Konum { get; set; }
        public CalisanDurum Durum { get; set; }
    }
}
