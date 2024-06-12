using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_V_Soru_Hoca
{
    internal class TamZamanli : Personel
    {
        public double TabanUcret { get; set; }

        public override double Maas { 
            get 
            {
                double prim = 0;

                if (YaptigiSatis > 0 && YaptigiSatis < 100_000)
                    prim = YaptigiSatis * 0.01;
                else if (YaptigiSatis >= 100_000 && YaptigiSatis < 250_000)
                    prim = YaptigiSatis * 0.02;
                else
                    prim = YaptigiSatis * 0.03;

                return TabanUcret + prim; 
            } 
        }

        public override string PersonelVerileri()
        {
            return $"{Ad} {Soyad} {TabanUcret} {Maas}";
        }
    }
}
