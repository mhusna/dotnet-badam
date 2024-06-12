using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_III.Models
{
    //[Index("HarfNotID", IsUnique = true)]
    [Table("OGRENCIDERS")]
    public class OgrenciDers
    {
        public int OgrenciDersID { get; set; }
        public int Not { get; set; }

        #region OGRENCİ
        public int OgrenciID { get; set; }
        public Ogrenci? Ogrenci { get; set; }
        #endregion

        #region DERS
        public int DersID { get; set; }
        public Ders? Ders { get; set; }
        #endregion

        #region HarfNot
        //[ForeignKey("HarfNot")]
        public int? HarfNotID { get; set; }
        public HarfNot? HarfNot { get; set; }
        #endregion
    }
}
