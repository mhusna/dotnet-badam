using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I.Models
{
    public class PersonelDetay
    {
        // Personel'in personel detayı var.
        [ForeignKey("Personel")]
        public int PersonelDetayID { get; set; }
        public int SicilNotu { get; set; }
        public string Aciklama { get; set; }

        //---- 1-1 İÇİN
        public Personel Personel { get; set; }
    }
}
