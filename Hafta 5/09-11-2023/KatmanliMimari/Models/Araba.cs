using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Araba
    {
        public int ArabaID { get; set; }
        public string Plaka { get; set; }
        public double Fiyat { get; set; }
        public string Resim { get; set; }

        #region Marka
        public int? MarkaID { get; set; }
        public Marka? Marka { get; set; }
        #endregion

        #region Model
        public int? ModelID { get; set; }
        public Model? Model { get; set; }
        #endregion

    }
}
