using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I.Models
{
    [Table("BOLUMLER")]
    public class Bolum
    {
        [Column("BOLUM_ID")]
        public int BolumID { get; set; }
        [Column("BOLUMADI",TypeName = "CHAR")]
        [StringLength(100)]
        public string BolumAdi { get; set; }

        #region Personel: Nav. Prop.
        public ICollection<Personel> Personeller { get; set; }
        #endregion
    }
}
