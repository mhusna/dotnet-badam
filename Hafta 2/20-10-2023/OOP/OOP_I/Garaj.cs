using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_I
{
    internal static class Garaj
    {
        public static void Boya(IBoyanabilir araba)
        {
            int newColorNumber;
            do
            {
                newColorNumber = new Random().Next(1, 16);
            } while (Araba.colors[newColorNumber] == (((Araba) araba).Color));

            ((Araba)araba).Color  = Araba.colors[newColorNumber];
        }
    }
}
