using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_II_Tekrar
{
    public class Urun
    {
        public int UrunID { get; set; }
        public int KategoriID { get; set; }
        public string UrunAdi { get; set; }
        public double Fiyat { get; set; }

        public override string ToString()
        {
            return $"{UrunID} - {KategoriID} - {UrunAdi} - {Fiyat}";
        }
    }
}
