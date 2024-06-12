using MehmetHusnaKisla.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MehmetHusnaKisla.Utilities
{
    public static class AdminUtility
    {
        public static void DisplayAdmin(string title, params Admin[]? list)
        {
            Console.Clear();
            Console.WriteLine($"## {title} ##");
            foreach (Admin admin in list)
                Console.WriteLine($"ID: {admin.AdminID} First Name: {admin.FirstName} Last Name: {admin.LastName} Password: {admin.Password}");

        }

        public static Admin GetInformation(Admin admin)
        {
            Console.Write("Admin Adı: ");
            admin.FirstName = Console.ReadLine();

            Console.Write("Admin Soyadı: ");
            admin.LastName = Console.ReadLine();

            Console.Write("Admin Şifresi: ");
            admin.Password = Console.ReadLine();

            return admin;
        }

    }
}
