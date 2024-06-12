using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_V_Soru
{
    internal abstract class Personel
    {
        public string PersonelAdi { get; set; }
        public int Satis { get; set; }
        public double Maas { get; set; }

        protected double Prim;

        public abstract double MaasHesapla();
        protected abstract double PrimHesapla();
        public abstract string BilgiGetir();
    }
}
