using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Utilities
{
    public static class ReportUtility
    {
        public static void DisplayReportMenu()
        {
            Console.Clear();
            Console.WriteLine("1- En Son Eklenen 10 Kitap");
            Console.WriteLine("2- Yayınevine Göre Kitaplar");
            Console.WriteLine("3- Satışı Durdurulan Kitaplar");
            Console.WriteLine("4- Fiyatına Göre Kitaplar (Z - A)");
        }
    }
}
