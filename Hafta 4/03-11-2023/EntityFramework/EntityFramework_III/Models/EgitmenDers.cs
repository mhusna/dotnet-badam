using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_III.Models
{
    [Table("EGITMENDERS")]
    public class EgitmenDers
    {
        public int EgitmenDersID { get; set; }

        #region EGITMEN
        public int EgitmenID { get; set; }
        public Egitmen? Egitmen { get; set; }
        #endregion

        #region DERS
        public int DersID { get; set; }
        public Ders? Ders { get; set; }
        #endregion

    }
}
