using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_II
{
    public class Urun : IComparable<Urun>
    {
        public int UrunID { get; set; }
        public int KategoriID { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }

        public int CompareTo(Urun obj)
        {
            return obj.UrunID.CompareTo(UrunID);
            // return UrunID.CompareTo(obj.UrunID) * -1;
        }

        public override string ToString()
        {
            return $"{UrunID} - {KategoriID} - {UrunAdi} - {Fiyat}";
        }
    }
}
