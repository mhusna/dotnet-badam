using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_I_Hoca
{
    internal abstract class Arac
    {
        public ConsoleColor Renk { get; set; }

        public Arac()
        {
            Renk = Utility.GetRandomColor();
        }
    }
}