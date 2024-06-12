using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_I
{
    internal class Araba
    {
        public static string[] colors = { "Black", "DarkBlue", "DarkGreen", "DarkCyan", "DarkRed", "DarkMagenta",
                                   "DarkYellow", "Gray", "DarkGray", "Blue", "Green", "Cyan", "Red", "Magenta",
                                   "Yellow", "White"};

        public string Brand { get; set; }
        public string Color { get; set; }

        public Araba()
        {
            Random random = new Random();
            int number = random.Next(0, 16);
            Color = colors[number];
        }
    }
}
