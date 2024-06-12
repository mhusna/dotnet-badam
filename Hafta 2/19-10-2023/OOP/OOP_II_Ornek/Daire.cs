using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_II_Ornek
{
    internal class Daire
    {
        public int r { get; set; }
        public virtual double Hesapla()
        {
            return Math.PI * r * r;
        }
    }
}