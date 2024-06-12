using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_I
{
    internal static class ConsolePersonel
    {
        public static Personel PersonelAl()
        {
            Console.Clear();

            Personel personel = new Personel();

            Console.Write("ID Giriniz: ");
            personel.PersonelID = int.Parse(Console.ReadLine());

            Console.Write("Ad Giriniz: ");
            personel.Ad = Console.ReadLine();

            Console.Write("Soyad Giriniz: ");
            personel.Soyad = Console.ReadLine();

            Console.Write("Adres Giriniz: ");
            personel.Adres = Console.ReadLine();

            return personel;
        }

        public static int PersonelIdAl()
        {
            Console.Clear();

            Console.Write("ID Giriniz: ");
            return int.Parse(Console.ReadLine());
        }

        public static void PersonelListele(List<Personel> personeller)
        {
            Console.Clear();

            foreach (Personel personel in personeller)
                Console.WriteLine(personel);
        }
    }
}
