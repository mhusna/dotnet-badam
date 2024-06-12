using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_VI
{
    internal class Karsilastir : IComparer
    {
        public string NeyeGore { get; set; }
        public int Compare(object? x, object? y)
        {
            Urun urun1 = (Urun)x;
            Urun urun2 = (Urun)y;

            if (NeyeGore == "UrunID")
                return urun1.UrunID.CompareTo(urun2.UrunID);
            else if (NeyeGore == "UrunAdi")
                return urun1.UrunAdi.CompareTo(urun2.UrunAdi);
            else
                return urun1.Fiyat.CompareTo(urun2.Fiyat);
        }
    }
}
