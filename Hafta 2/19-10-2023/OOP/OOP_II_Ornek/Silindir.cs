using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_II_Ornek
{
    internal class Silindir : Daire
    {
        public int H { get; set; }
        public override double Hesapla()
        {
            return base.Hesapla() * H;
        }
    }
}
