using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_II.Models
{
    [Table("DERSOGRENCILER")]
    public class DersOgrenci
    {
        public int ID { get; set; }
        public double DersNotu { get; set; }
        public char HarfNotu { get; set; }

        #region Ders
        public int DersID { get; set; }
        public Ders Ders { get; set; }
        #endregion

        #region Ogrenci
        public int OgrenciID { get; set; }
        public Ogrenci Ogrenci { get; set; }
        #endregion

        public DersOgrenci()
        {
            if (DersNotu >= 0 && DersNotu < 50)
                HarfNotu = 'F';
            else if (DersNotu >= 50 && DersNotu < 60)
                HarfNotu = 'E';
            else if (DersNotu >= 60 && DersNotu < 70)
                HarfNotu = 'D';
            else if (DersNotu >= 70 && DersNotu < 80)
                HarfNotu = 'C';
            else if (DersNotu >= 80 && DersNotu < 90)
                HarfNotu = 'B';
            else
                HarfNotu = 'A';
        }

    }
}
