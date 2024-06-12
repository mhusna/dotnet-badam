using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_VI
{
    internal class Urun
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }

        public override string ToString()
        {
            return $"{UrunID} {UrunAdi} {Fiyat} \n";
        }
    }
}
