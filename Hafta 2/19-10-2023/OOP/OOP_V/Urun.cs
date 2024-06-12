using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_V
{
    internal class Urun : IComparable
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }

        public int CompareTo(object? obj)
        {
            Urun urun = obj as Urun;

            //if (urun.UrunID > UrunID)
            //    return -1;
            //else if (urun.UrunID == UrunID)
            //    return 0;
            //else
            //    return 1;

            return UrunID.CompareTo(urun.UrunID);
        }

        public override string ToString()
        {
            return $"{UrunID} {UrunAdi} {Fiyat} \n";
        }
    }
}
