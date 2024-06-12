using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_V_Soru
{
    internal class PersonelIslemleri
    {
        public string BilgiGetir(Personel personel)
        {
            personel.MaasHesapla();
            return $"{personel.PersonelAdi} - {personel.Maas}";
        }
    }
}
