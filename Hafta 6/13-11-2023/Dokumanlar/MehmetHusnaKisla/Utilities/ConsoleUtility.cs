using MehmetHusnaKisla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Utilities
{
    public static class ConsoleUtility
    {
        public static void DisplayMainMenu()
        {
            Console.Clear();
            Console.WriteLine("1- Admin İşlemleri");
            Console.WriteLine("2- Kitap İşlemleri");
            Console.WriteLine("3- Yayınevi İşlemleri");
            Console.WriteLine("4- Raporlar");

            Console.WriteLine("\nÇıkmak İçin '-1' Tuşlayınız.");
        }

        public static void DisplaySubMenu(string entityName)
        {
            Console.Clear();
            Console.WriteLine($"1- {entityName} Ara");
            Console.WriteLine($"2- {entityName} Ekle");
            Console.WriteLine($"4- {entityName} Güncelle");
            Console.WriteLine($"3- {entityName} Sil");
            Console.WriteLine($"5- {entityName} Listesi");
        }

        public static int GetID()
        {
            Console.Write("\nID giriniz: ");

            return int.Parse(Console.ReadLine());
        }

        public static int GetChoice()
        {
            Console.Write("\n=> Seçiminiz: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
