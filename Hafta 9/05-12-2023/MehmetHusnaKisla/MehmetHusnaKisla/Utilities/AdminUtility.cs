using MehmetHusnaKisla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Utilities
{
    public static class AdminUtility
    {
        /*
         Genel yazdırma metodu.
         */
        public static void DisplayAdmin(string title, params Admin[]? list)
        {
            Console.Clear();
            Console.WriteLine($"## {title} ##");
            foreach (Admin admin in list)
                Console.WriteLine($"ID: {admin.AdminID} Password: {admin.Password}");
        }

        // Admin bilgisi alma
        public static Admin GetInformation(Admin admin)
        {
            Console.Write("Admin Kullanıcı Adı: ");
            admin.UserName = Console.ReadLine();

            Console.Write("Admin Şifresi: ");
            admin.Password = Console.ReadLine();

            return admin;
        }

        // Şifreleme metodu
        public static string sha256_hash(string sifre)
        { 
            using (SHA256 hash = SHA256Managed.Create()) 
            { 
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre))
                             .Select(l => l.ToString("X2"))); 
            } 
        }

        // Menü yazdırma
        public static void DisplayAdminMenu()
        {
            Console.Clear();
            Console.WriteLine($"1- Admin Ekle");
        }

    }
}
