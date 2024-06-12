using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookShop.Models.Enums;

namespace BookShop.Models
{
    public class Kitap
    {
        public int KitapID { get; set; }
        public string KitapAdi { get; set; }
        public KitapDurum SatisDurum { get; set; }
        public double Fiyat { get; set; }

        #region YayinEvi
        public int? YayinEviID { get; set; }
        public YayinEvi? YayinEvi { get; set; }
        #endregion

    }
}
