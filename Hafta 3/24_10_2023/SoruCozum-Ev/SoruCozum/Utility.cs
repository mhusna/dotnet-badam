using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoruCozum
{
    internal static class Utility<T> where T : class
    {
        public static void Print(List<T> entities)
        {
            foreach (T entity in entities)
                Console.WriteLine(entity);
        }
    }
}
