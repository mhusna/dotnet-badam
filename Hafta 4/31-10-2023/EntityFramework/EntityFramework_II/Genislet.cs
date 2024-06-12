using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_II
{
    public static class Genislet
    {
        public static int KareAl(this int sayi)
        {
            return sayi * sayi;
        }
        public static int KupAl(this int sayi)
        {
            return sayi.KareAl() * sayi;
            //return sayi * sayi * sayi;
        }

        public static double IkiyeBol(this int sayi)
        {
            return sayi / 2;
        }

        public static int IstenenSayiyaBol(this int sayi, int bolunecekSayi)
        {
            return sayi / bolunecekSayi;
        }

        public static string Cevir(this string ifade)
        {
            string ters = "";
            for (int i = ifade.Length - 1; i >= 0; i--)
                ters += ifade[i];
            return ters;
        }


    }
}
