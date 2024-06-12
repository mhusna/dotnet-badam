using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_II.Models
{
    [Table("DERSEGITMENLER")]
    public class DersEgitmen
    {
        public int ID { get; set; }

        #region Egitmen
        public int EgitmenID { get; set; }
        public Egitmen Egitmen { get; set; }
        #endregion

        #region Ders
        public int DersID { get; set; }
        public Ders Ders { get; set; }
        #endregion
    }
}
