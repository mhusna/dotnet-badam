using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I_Tekrar.Models
{
    public class PersonelProje
    {
        public int ID { get; set; }
        public Personel Personel { get; set; }
        public int PersonelID { get; set; }

        public Bolum Bolum { get; set; }
        public int BolumID { get; set; }
    }
}
