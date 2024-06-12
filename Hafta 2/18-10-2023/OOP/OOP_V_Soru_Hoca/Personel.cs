using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_V_Soru_Hoca
{
    internal abstract class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public abstract double Maas { get; }
        public double YaptigiSatis { get; set; }

        public abstract string PersonelVerileri();
    }
}
