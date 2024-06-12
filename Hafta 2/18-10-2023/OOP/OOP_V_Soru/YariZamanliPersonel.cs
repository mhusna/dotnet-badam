using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_V_Soru
{
    internal class YariZamanliPersonel : Personel
    {
        public double CalistigiSaat { get; set; }
        public double SaatUcreti { get; set; }

        public override string BilgiGetir()
        {
            MaasHesapla();
            return $"Ad: {PersonelAdi} - Satis: {Satis} - Calistigi Saat: {CalistigiSaat} - Saat Ucreti: {SaatUcreti} - Prim: {Prim} - Maas: {Maas}";
        }

        public override double MaasHesapla()
        {
            Maas = (CalistigiSaat * SaatUcreti) + PrimHesapla();
            return Maas;
        }

        protected override double PrimHesapla()
        {
            Prim = Satis * 0.01;
            return Prim;
        }
    }
}
