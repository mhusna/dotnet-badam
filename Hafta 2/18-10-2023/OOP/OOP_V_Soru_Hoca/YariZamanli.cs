using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_V_Soru_Hoca
{
    internal class YariZamanli : Personel
    {
        public int CalistigiSaat { get; set; }
        public double SaatUcreti { get; set; }

        public override double Maas
        {
            get
            {
                return (CalistigiSaat * SaatUcreti) + YaptigiSatis * 0.01;
            }
        }

        public override string PersonelVerileri()
        { 
            return $"{Ad} {Soyad} {CalistigiSaat} {SaatUcreti} {Maas}";
        }
    }
}
