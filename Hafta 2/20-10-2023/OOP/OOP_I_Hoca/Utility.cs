using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_I_Hoca
{
    internal static class Utility
    {
        public static ConsoleColor GetRandomColor()
        {
            // Enum anlatılmadığından böyle yazdık.
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, ConsoleColor.Red);
            hashtable.Add(2, ConsoleColor.Blue);
            hashtable.Add(3, ConsoleColor.Yellow);
            hashtable.Add(4, ConsoleColor.DarkGreen);

            return (ConsoleColor)hashtable[new Random().Next(1, 5)];
        }

        public static void EkranaYaz(Arac arac)
        {
            Console.ForegroundColor = arac.Renk;
            Console.WriteLine(arac.GetType().Name + " " + arac.Renk.ToString());
        }
    }
}