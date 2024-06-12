using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I.Models
{
    [Table("PERSONELLER")]
    public class Personel
    {
        [Column("PERSONEL_ID")]
        public int PersonelID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        #region Bolum: Id Kullanarak
        public int BolumID { get; set; }
        public Bolum Bolum { get; set; }
        #endregion

        #region Proje: Id Kullanmadan
        public Proje Proje { get; set; }
        #endregion
    }
}
