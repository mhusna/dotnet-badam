using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Models
{
    public class YayinEvi
    {
        public int YayinEviID { get; set; }
        public string Ad { get; set; }

        public ICollection<Kitap>? Kitaplar { get; set; }
    }
}
