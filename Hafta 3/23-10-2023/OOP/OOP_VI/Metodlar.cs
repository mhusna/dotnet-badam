using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_VI
{
    // Dönüş tipi void olan ve parametresiz metotlar tutabilir.
    delegate void Temsilci();

    internal static class Metodlar
    {
        public static void Merhaba()
        {
            Console.WriteLine("Merhaba");
        }

        public static void Hi()
        {
            Console.WriteLine("Hi");
        }

        public static void Hola()
        {
            Console.WriteLine("Hola");
        }

        public static string Gunaydin()
        {
            return "Gunaydin";
        }

        public static void IyiGunler(string ad)
        {
            Console.WriteLine("İyi günler " + ad);
        }
    }
}
