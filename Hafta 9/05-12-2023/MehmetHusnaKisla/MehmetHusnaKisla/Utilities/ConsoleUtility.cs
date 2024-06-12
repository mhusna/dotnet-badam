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
        // Ana menüyü yazdırma fonksiyonu
        public static void DisplayMainMenu()
        {
            Console.Clear();
            Console.WriteLine("1- Admin İşlemleri");
            Console.WriteLine("2- Sanatçı İşlemleri");
            Console.WriteLine("3- Albüm İşlemleri");
            Console.WriteLine("4- Rapor İşlemleri");

            Console.WriteLine("\nÇıkmak İçin '-1' Tuşlayınız.");
        }

        // Alt menü yazdırma fonksiyonu
        public static void DisplaySubMenu(string entityName)
        {
            Console.Clear();
            Console.WriteLine($"1- {entityName} Ara");
            Console.WriteLine($"2- {entityName} Ekle");
            Console.WriteLine($"3- {entityName} Güncelle");
            Console.WriteLine($"4- {entityName} Sil");
            Console.WriteLine($"5- {entityName} Listesi");
        }

        // id numarasını alır
        public static int GetID()
        {
            Console.Write("\nID giriniz: ");

            return int.Parse(Console.ReadLine());
        }

        // seçim alır.
        public static int GetChoice()
        {
            Console.Write("\n=> Seçiminiz: ");
            return int.Parse(Console.ReadLine());
        }
    }
}
