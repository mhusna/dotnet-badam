using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Hoca.Models
{
    public class Yayinevi
    {
        public int YayinEviID { get; set; }
        public string YayinEviAdi { get; set; }
        public string Adres { get; set; }
        public ICollection<Kitap>? Kitaplar { get; set; }
    }
}
