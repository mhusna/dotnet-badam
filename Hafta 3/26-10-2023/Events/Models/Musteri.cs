using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Musteri
    {
        public int MusteriID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Hesap Hesap { get; set; }
        public Islem Islem { get; set; }

        public void IslemYap(Banka banka)
        {
            banka.IslemYap(this);
        }
    }
}