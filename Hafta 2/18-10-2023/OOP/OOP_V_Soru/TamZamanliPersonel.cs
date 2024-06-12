using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_V_Soru
{
    internal class TamZamanliPersonel : Personel
    {
        public double TabanMaas { get; set; }

        public override string BilgiGetir()
        {
            MaasHesapla();
            return $"Ad: {PersonelAdi} - Taban Maas: {TabanMaas} - Satis: {Satis} - Prim: {Prim} - Maas: {Maas}";
        }

        public override double MaasHesapla()
        {
            Maas = TabanMaas + PrimHesapla();
            return Maas;
        }

        protected override double PrimHesapla()
        {
            if (Satis < 100000)
                Prim = Satis * 0.01;
            else if (Satis >= 100000 && Satis < 250000)
                Prim = Satis * 0.02;
            else
                Prim = Satis * 0.03;

            return Prim;
        }

    }
}
