using BookShop_Hoca.Data;
using BookShop_Hoca.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BookShop_Hoca.Utilities
{
    public static class Utility
    {
        public static string SifreMD5(string sifre)
        {
            MD5 md5 = MD5.Create();
            var result = md5.ComputeHash(Encoding.UTF8.GetBytes(sifre));
            string str = "";

            foreach (var item in result)
                str += item.ToString("x2");

            return str;
        }

        public static bool Login(LoginDTO login)
        {
            KitapContext context = new KitapContext();
            var kullanici = context.Kullanicilar
                .FirstOrDefault(x => x.KullaniciAdi == login.KullaniciAdi && x.Sifre == Utility.SifreMD5(login.Sifre));

            return !(kullanici == null);
        }

        public static LoginDTO Login()
        {
            LoginDTO login = new LoginDTO();
            Console.Write("Kullanıcı adını giriniz: ");
            login.KullaniciAdi = Console.ReadLine();

            Console.Write("Sifre giriniz: ");
            login.Sifre = Console.ReadLine();

            return login;
        }

        public static bool BoyutKontrolu(string sifre)
        {
            return true;
        }

        public static int Menu()
        {
            int secim = 0;
            Console.WriteLine("1- Kitap Ekle");
            Console.WriteLine("2- Kitap Guncelle");
            Console.WriteLine("5- En Son Eklenen 10 Kitap");
            Console.WriteLine("6- Satisi Durdurulan Kitaplar");
            Console.WriteLine("7- Yayinevine Gore Kitaplar");

            Console.Write("Seciminiz: ");
            secim = int.Parse(Console.ReadLine());

            return secim;
        }
    }
}
