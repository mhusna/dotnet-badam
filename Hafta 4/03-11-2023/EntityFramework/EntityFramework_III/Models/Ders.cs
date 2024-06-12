using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_III.Models
{
    [Table("DERSLER")]
    public class Ders
    {
        public int DersID { get; set; }
        public string DersAdi { get; set; }
        public int Kredi { get; set; }

        public ICollection<OgrenciDers>? Ogrenciler { get; set; }
        public ICollection<EgitmenDers>? Egitmenler { get; set; }
    }
}
