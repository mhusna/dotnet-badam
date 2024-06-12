using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I_Tekrar.Models
{
    public class PersonelDetay
    {
        // Personel Sınıfının PersonelDetayID'diye bir foreign key'i olduğunu söyledik.
        [ForeignKey("Personel")]
        public int PersonelDetayID { get; set; }
        public int SicilNotu { get; set; }
        public string Aciklama { get; set; }

        #region One to One: Personel
        public Personel Personel { get; set; }
        #endregion
    }
}
