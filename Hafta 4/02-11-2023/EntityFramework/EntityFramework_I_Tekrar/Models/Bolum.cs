using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I_Tekrar.Models
{
    public class Bolum
    {
        public int BolumID { get; set; }
        public string BolumAdi { get; set; }

        #region One to Many: Personel

        // Navigation Property
        public ICollection<Personel> Personeller { get; set; }

        #endregion
    }
}
