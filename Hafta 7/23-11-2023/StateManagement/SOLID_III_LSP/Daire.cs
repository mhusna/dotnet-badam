using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_III_LSP
{
    public class Daire
    {
        public double r { get; set; }

        public virtual double Hesapla()
        {
            return Math.PI * r * r;
        }
    }
}
