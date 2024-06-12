using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_II.Models
{
    [Table("OGRENCILER")]
    public class Ogrenci
    {
        public int OgrenciID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        #region Dersler
        public ICollection<DersOgrenci> Ogrenciler { get; set; }

        #endregion
    }
}
