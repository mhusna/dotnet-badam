using Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Concrete
{
    public class Siparis
    {
        public List<AnaUrun> Urunler { get; set; }
        public TimeOnly HazirlanmaSuresi { get; }
        public double Tutar { get; }

        public Siparis(params AnaUrun[] urunler)
        {
            Urunler = urunler.ToList();
            foreach (Urun urun in urunler)
            {
                HazirlanmaSuresi.Add(urun.HazirlanisSuresi);
                Tutar += urun.Fiyat;
            }
        }
    }
}
