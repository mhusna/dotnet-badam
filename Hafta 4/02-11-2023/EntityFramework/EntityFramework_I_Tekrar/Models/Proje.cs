using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I_Tekrar.Models
{
    public class Proje
    {
        public int ProjeID { get; set; }
        public string ProjeAdi { get; set; }

        #region Many to Many: Personel

        // Default Hali
        // public ICollection<Personel> Personeller { get; set; }

        // İşimizi kolaylaştıran yöntem
        public ICollection<PersonelProje> Personeller { get; set; }

        #endregion

    }
}
