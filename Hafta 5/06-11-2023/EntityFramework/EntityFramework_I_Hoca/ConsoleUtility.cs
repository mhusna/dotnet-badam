using EntityFramework_I_Hoca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_I_Hoca
{
    public class ConsoleUtility
    {
        public static Urun UrunVerisiAl(bool idAl = false)
        {
            Urun urun = new Urun();

            if (idAl)
            {
                Console.Write("UrunID'si giriniz: ");
                urun.UrunID = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ürün adı giriniz: ");
            urun.UrunAdi = Console.ReadLine();

            Console.WriteLine("Fiyat giriniz: ");
            urun.Fiyat = double.Parse(Console.ReadLine());

            Console.WriteLine("KategoriID giriniz: ");
            urun.KategoriID = int.Parse(Console.ReadLine());

            return urun;
        }

        public static Kategori KategoriVerisiAl(bool idAl = false)
        {
            Kategori kategori = new Kategori();

            if (idAl)
            {
                Console.Write("KategoriID'si giriniz: ");
                kategori.KategoriID = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Ürün adı giriniz: ");
            kategori.KategoriAdi = Console.ReadLine();

            return kategori;
        }

        public static void Listele<T>(List<T> liste)
        {
            Console.WriteLine(typeof(T).Name + " Listesi");
            foreach (T item in liste)
                Console.WriteLine(item);
        }
    }
}
