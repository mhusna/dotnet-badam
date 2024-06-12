using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I_Tekrar.Models
{
    public class Personel
    {
        public int PersonelID { get; set; }
        public string PersonelAd { get; set; }
        public string Soyad { get; set; }
        public double Maas { get; set; }

        #region One to One: PersonelDetay
        public PersonelDetay PersonelDetay { get; set; }
        #endregion

        #region One to Many: Bolum

        // Kod yükümüzü azaltacak property
        public int BolumID { get; set; }

        // Navigation Property
        public Bolum Bolum { get; set; }

        #endregion

        #region Many to Many: Proje

        // Default Hali
        // public ICollection<Proje> Projeler { get; set; }

        // İşimizi kolaylaştıran yöntem
        public ICollection<PersonelProje> Projeler { get; set; }

        #endregion

    }
}
