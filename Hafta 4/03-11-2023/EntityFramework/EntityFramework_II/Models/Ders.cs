using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_II.Models
{
    [Table("DERSLER")]
    public class Ders
    {
        public int DersID { get; set; }
        public string DersAdi { get; set; }

        #region Ogrenciler
        public ICollection<DersOgrenci> Ogrenciler { get; set; }

        #endregion

        #region Egitmenler
        public ICollection<DersEgitmen> Egitmenler { get; set; }
        #endregion
    }
}
