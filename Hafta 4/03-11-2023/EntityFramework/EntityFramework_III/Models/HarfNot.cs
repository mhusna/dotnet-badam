using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_III.Models
{
    [Table("HARFNOTLARI")]
    public class HarfNot
    {
        public int HarfNotID { get; set; }
        public string Harf { get; set; }
        public int MinDeger { get; set; }
        public int MaxDeger { get; set; }

        public ICollection<OgrenciDers> Dersler { get; set; }
    }
}
