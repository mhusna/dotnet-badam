using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_III_LSP
{
    public class Silindir : Daire
    {
        public double h { get; set; }
        public override double Hesapla()
        {
            return base.Hesapla() * h;
        }
    }
}
