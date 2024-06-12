using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I.Models
{
    public class Proje
    {
        public int ProjeID { get; set; }
        public string ProjeAdi { get; set; }


        //---- ÇOKA ÇOK İÇİN
        //public ICollection<Personel> Personeller { get; set; }
        public ICollection<PersonelProje> Personeller { get; set; }

    }
}
