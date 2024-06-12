using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I.Models
{
    [Table("PROJELER")]
    public class Proje
    {
        public int ProjeID { get; set; }
        [Column("PROJEADI", TypeName = "CHAR"), StringLength(150)]
        public string ProjeAdi { get; set; }

        #region Personel: Nav. Prop.
        public ICollection<Personel> Personeller { get; set; }
        #endregion
    }
}
