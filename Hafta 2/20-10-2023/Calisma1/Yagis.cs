using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calisma1
{
    internal class Yagis
    {
        public int X { get; set; }
        public int Y { get; set; }
        public string Karakter { get; set; }

        public Yagis(string karakter)
        {
            X = new Random().Next(5, 110);
            Y = 1;
            Karakter = karakter;
        }
    }
}
