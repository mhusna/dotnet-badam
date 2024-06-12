using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_V_Soru_Hoca
{
    internal static class PersonelIslemleri
    {
        static ArrayList _personeller = new ArrayList();

        public static void PersonelEkle(Personel personel)
        {
            _personeller.Add(personel);
        }

        public static ArrayList PersonelListe()
        {
            return _personeller;
        }
    }
}
