using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_VII
{
    internal static class Utility
    {
        public static void YazString(string[] dizi)
        {
            foreach (object item in dizi)
                Console.Write(item+" ");
            Console.WriteLine();
        }

        public static void YazDouble(double[] dizi)
        {
            foreach (double item in dizi)
                Console.Write(item+" ");
            Console.WriteLine();
        }

        public static void YazInt(int[] dizi)
        {
            foreach (double item in dizi)
                Console.Write(item+" ");
            Console.WriteLine();
        }

        public static void Yazdir<T>(T[] dizi)
        {
            foreach (T item in dizi)
                Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}