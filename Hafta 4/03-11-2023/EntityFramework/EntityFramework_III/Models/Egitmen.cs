using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_III.Models
{
    [Table("EGITMENLER")]
    public class Egitmen
    {
        public int EgitmenID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public ICollection<EgitmenDers>? Dersler { get; set; }
    }
}
