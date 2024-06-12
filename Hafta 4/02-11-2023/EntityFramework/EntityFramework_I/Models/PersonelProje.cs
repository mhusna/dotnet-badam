using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I.Models
{
    public class PersonelProje
    {
        // Erişim kolaylığı için ve kodlama tarafını rahatlatır.
        public int ID { get; set; }
        public int PersonelID { get; set; }
        public int ProjeID { get; set; }
        public Proje Proje { get; set; }
        public Personel Personel { get; set; }
    }
}